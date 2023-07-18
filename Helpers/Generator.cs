using System;

// namespace RazorPress.Helpers.Generator;

public class CustomizableSiteFields {
    public string title;
    public string database_name;

    public string database_user;

    public CustomizableSiteFields(){

        object[] classFields = typeof(CustomizableSiteFields).GetCustomAttributes(false);

        Console.WriteLine(classFields.ToString());

        if(title == null || title.Length == 0){
            title = "RazorPress Website";
        }


        if(database_name == null || database_name.Length == 0){
            database_name = "rp_website";
        }

        // if()
    }

}

public class Generator {
    
    public static void Main(){
        var customFields = new CustomizableSiteFields();
    }
    // public bool CopySkeletonWithCustomAttrs(){

    // }

}
