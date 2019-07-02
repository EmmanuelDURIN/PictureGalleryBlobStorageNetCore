using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using PictureGalleryBlobStorageNetCore.Models;
using PictureGalleryBlobStorageNetCore.ViewModels;
using System.Threading.Tasks;

namespace PictureGalleryBlobStorageNetCore.BlobStorage
{
  public class BlobStorageManager
  {
    public static string StorageAccount => "valetkeypattern";
    public static string StorageAccountKey => "9bG49k6A1nLZG6B9oKzNg8AGI1y4VfLyQwbWZhpa/3YBMzP+HkXGuf9cu+IfM0vvJwcxXDi2GwZQJrU+ArWQqA==";
    private const string containerName = "imagesupload";

    public static string ContainerName => containerName;

    private static CloudBlobContainer GetContainer()
    {
      CloudBlobContainer container = null;
      // S'inspirer de la planche du cours 'Création d'un container'
      // TODO Make a connection string
      // ...
      // TODO Create the blob client object.
      // ....
      // TODO Get a reference to a container to use for the sample code, and create if it does not exist.
      // ...
      // En cas de création, mettre les permissions de type Blob
      return container;
    }
    public async Task<IEnumerable<Picture>> GetPicturesAsync()
    {
      // TODO : retrouver la liste des images (Uri) dans le container
      return null;
    }
    private async Task<DateTime> GetDateAsync(CloudBlobContainer container, IListBlobItem blobItem)
    {
      // TODO : retrouver la date dans les métadonnées du blob
      return DateTime.Now;
    }
    public async Task SavePictureAsync(PictureUploadViewModel picture)
    {
      // TODO : sauvegarder l'écriture en blob storage
    }
    private string GetImageTypeFromExtension(string filename)
    {
      string ext = Path.GetExtension(filename).ToLower();
      switch (ext)
      {
        case ".jpeg":
        case ".jpg":
          return "image/jpeg";
        case ".png":
          return "image/png";
        case ".tiff":
          return "image/tiff";
        case ".gif":
          return "image/gif";
      }
      return null;
    }
  }
}
