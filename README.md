# Check_MailRu_User_Status
//A simple static class that checks mail.ru user status by it's address.<br>
//It uses http://status.mail.ru/?address@dom.ru pattern to fetch an image and then check if it "red" or "green".<br>
//It desn't actually use colors. :D

// 570 - red status image length<br>
// 349 - green status image length<br>
if(client.DownloadData(new System.Uri(addr)).Length > 400)

//The information was taken from http://geektimes.ru/post/127684/
