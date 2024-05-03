using System.Net.Http.Headers;
using System.Text;

namespace ChatServer.Bot {
    internal static class GeminiAPI {
        // make it callable in the chatapp
        public static async Task<string> SendRequestAndGetResponse(string userInput) {
            string jsonBody = $@"{{
                ""contents"": [
                    {{
                        ""role"": """",
                        ""parts"": [
                            {{
                                ""text"": ""{userInput}""
                            }}
                        ]
                    }}
                ],
                ""generationConfig"": {{
                    ""temperature"": 0.9,
                    ""topK"": 50,
                    ""topP"": 0.95,
                    ""maxOutputTokens"": 4096,
                    ""stopSequences"": []
                }},
                ""safetySettings"": [

                ]
            }}";

            using (var client = new HttpClient()) {
                var request = new HttpRequestMessage(HttpMethod.Post, $"https://generativelanguage.googleapis.com/v1beta/models/gemini-pro:generateContent?key=AIzaSyA4_FnJD9hPi4e7hh-cV6XEHXbyHUezycE");
                request.Content = new StringContent(jsonBody, Encoding.UTF8);
                request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.SendAsync(request).ConfigureAwait(false);

                if (response.IsSuccessStatusCode) {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    return responseBody.Substring(responseBody.IndexOf("\"text\": \"") + 9, responseBody.IndexOf("\"", responseBody.IndexOf("\"text\": \"") + 10) - responseBody.IndexOf("\"text\": \"") - 9);
                } else {
                    // MessageBox.Show("Error1");
                    return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }
        }
    }
}
