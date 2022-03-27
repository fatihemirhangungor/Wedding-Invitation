using System.Collections.Generic;

namespace Wedding_Invitation.Models
{
    public class Repository
    {
        private static List<Response> responseList = new List<Response>();
        public static IEnumerable<Response> responseEnum => responseList;
        public static void AddResponse(Response response)
        {
            responseList.Add(response);
        }
    }
}
