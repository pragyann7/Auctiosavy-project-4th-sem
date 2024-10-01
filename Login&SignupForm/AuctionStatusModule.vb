Imports System.Data.SqlClient

Module AuctionStatusManager
    'Dim connectionString As String = "Data Source=192.168.1.69;Initial Catalog=UsersDB;Persist Security Info=True;User ID=SA;Password=MyStrongPass123"

    ' Method to update auction status based on current time
    Public Sub UpdateAuctionStatus()
        Dim currentTime As DateTime = DateTime.Now  ' Get current time once at the start

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' SQL query to update the status of auction items
            Dim query As String = "
                UPDATE AuctionItems
                SET status = CASE 
                    WHEN @CurrentTime < start_time THEN 'pending'
                    WHEN @CurrentTime >= start_time AND @CurrentTime <= end_time THEN 'active'
                    WHEN @CurrentTime > end_time THEN 'ended'
                    ELSE status  -- Keep the current status if no conditions match
                END
            "

            Using command As New SqlCommand(query, connection)
                ' Use parameterized query to pass current time
                command.Parameters.AddWithValue("@CurrentTime", currentTime)

                Try
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    Console.WriteLine(rowsAffected & " auction items updated.")
                    ' After updating auction statuses, check for winners
                    'DeclareWinners() ' Call the method to declare winners
                Catch ex As SqlException
                    Console.WriteLine("Error updating auction status: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Method to declare winners for ended auctions
    Private Sub DeclareWinners()
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' SQL command to find the highest bid for ended auctions and insert the winner
            Dim query As String = "
            INSERT INTO Winners (item_id, user_id, winning_bid, winning_time)
            SELECT b.item_id, b.user_id, b.bid_amount AS winning_bid, GETDATE() AS winning_time
            FROM Bids b
            WHERE b.bid_amount = (
                SELECT MAX(b2.bid_amount)
                FROM Bids b2
                WHERE b2.item_id = b.item_id
            )
            AND b.item_id IN (
                SELECT item_id 
                FROM AuctionItems 
                WHERE status = 'ended'
                AND item_id NOT IN (SELECT item_id FROM Winners)  -- Exclude products that already have winners
            )
        "

            Using command As New SqlCommand(query, connection)
                Try
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    ' Log or display information only if winners were declared
                    If rowsAffected > 0 Then
                        Console.WriteLine("Auction winners have been declared.")
                    End If
                Catch ex As SqlException
                    ' Log the error instead of showing a MessageBox
                    Console.WriteLine("Error declaring auction winners: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Module
