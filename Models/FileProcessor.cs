namespace RealCashMs.Models;

public class FileProcessor{
    
    public DirectoryInfo directoryInfo{get;private set;} = new DirectoryInfo(@"D:\MVCPROJECTS\TESTSUNCOUNTED\RealCashMs\wwwroot\stock photos");

    public List<ImageClass> testImgClass{get;private set;} = new List<ImageClass>();
    private List<ImageClass> listCopy{get;set;} = new List<ImageClass>();

    public List<List<ImageClass>> listOfLists{get;private set;} = new List<List<ImageClass>>();
    public void PrintFileNames(){
        int initializer = 500;

        foreach(FileInfo testFile in this.directoryInfo.GetFiles()){
           this.testImgClass.Add(new ImageClass(testFile.Name,testFile.Name,initializer+=200));
        }
        foreach(ImageClass oneImgClass in this.testImgClass){
            if(listCopy.Count % 3 != 0) {
                listCopy.Add(oneImgClass);
            }
            else{
                listOfLists.Add(listCopy);
                listCopy.Clear();
                listCopy.Add(oneImgClass);
            }
        }
        if(listCopy.Count != 0){
            listOfLists.Add(listCopy);
        }
    }
}