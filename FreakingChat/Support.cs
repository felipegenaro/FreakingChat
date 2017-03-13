namespace Chat
{
    public static class Support
    {
        public static string[] SplitMessage(string message, int number)
        {
            string[] messages = new string[number];

            if (message.Split().Length >= number)
            {
                for (int i = 0; i < number; i++)
                {
                    if (i == number - 1)
                    {
                        messages[i] = message;
                    }
                    else
                    {
                        messages[i] = message.Substring(0, message.IndexOf(' '));
                        message = message.Remove(0, messages[i].Length + 1);
                    }
                }
            }

            return messages;
        }
    }
}