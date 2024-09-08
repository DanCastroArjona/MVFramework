#if UNITY_EDITOR
using MVFramework.Editor.FolderRepositories;
using UnityEditor;

namespace MVFramework.Editor.Services
{
    public class MvcFolderService : FolderGeneratorService<MvcFolders>
    {
        [MenuItem("Assets/Create/Mvc/Generate MVC Folders")]
        private static void GenerateMVCFoldersInPath()
        {
            GenerateFoldersInSelectedGuidPath();
        }
    }
    
    public class MvpFolderService : FolderGeneratorService<MvpFolders>
    {
        [MenuItem("Assets/Create/Mvc/Generate MVP Folders")]
        private static void GenerateMVPFoldersInPath()
        {
            GenerateFoldersInSelectedGuidPath();
        }
    }
}
#endif