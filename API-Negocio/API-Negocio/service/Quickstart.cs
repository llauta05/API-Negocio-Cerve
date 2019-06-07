using Microsoft.Extensions.Configuration.CommandLine;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace API_Negocio.service
{
    public class Quickstart
    {
        public static string Usage = @"Usage:
        C:\> dotnet run command YOUR_PROJECT_ID
            Where command is one of
            initialize-project-id
            add-data-1
            add-data-2
            retrieve-all-documents
        ";

        private static void InitializeProjectId(string project)
        {
            // [START fs_initialize_project_id]
            FirestoreDb db = FirestoreDb.Create(project);
            Console.WriteLine("Created Cloud Firestore client with project ID: {0}", project);
            // [END fs_initialize_project_id]
        }

        private static async Task AddData1(string project)
        {
            FirestoreDb db = FirestoreDb.Create(project);
            // [START fs_add_data_1]
            DocumentReference docRef = db.Collection("users").Document("alovelace");
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                { "First", "Ada" },
                { "Last", "Lovelace" },
                { "Born", 1815 }
            };
            await docRef.SetAsync(user);
            // [END fs_add_data_1]
            Console.WriteLine("Added data to the alovelace document in the users collection.");
        }

        private static async Task AddData2(string project)
        {
            FirestoreDb db = FirestoreDb.Create(project);
            // [START fs_add_data_2]
            DocumentReference docRef = db.Collection("users").Document("aturing");
            Dictionary<string, object> user = new Dictionary<string, object>
            {
                { "First", "Alan" },
                { "Middle", "Mathison" },
                { "Last", "Turing" },
                { "Born", 1912 }
            };
            await docRef.SetAsync(user);
            // [END fs_add_data_2]
            Console.WriteLine("Added data to the aturing document in the users collection.");
        }

        private static async Task RetrieveAllDocuments(string project)
        {
            FirestoreDb db = FirestoreDb.Create(project);
            // [START fs_get_all]
            CollectionReference usersRef = db.Collection("users");
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                Console.WriteLine("User: {0}", document.Id);
                Dictionary<string, object> documentDictionary = document.ToDictionary();
                Console.WriteLine("First: {0}", documentDictionary["First"]);
                if (documentDictionary.ContainsKey("Middle"))
                {
                    Console.WriteLine("Middle: {0}", documentDictionary["Middle"]);
                }
                Console.WriteLine("Last: {0}", documentDictionary["Last"]);
                Console.WriteLine("Born: {0}", documentDictionary["Born"]);
                Console.WriteLine();
            }
            // [END fs_get_all]
        }

    }
}
