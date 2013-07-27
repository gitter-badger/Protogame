using System;
using Protogame;

namespace ProtogameAssetManager
{
    public interface IAssetEditor
    {
        void SetAsset(IAsset asset);
        void BuildLayout(SingleContainer editorContainer, IAssetManager assetManager);
        void FinishLayout(SingleContainer editorContainer, IAssetManager assetManager);
        void Bake(IAssetManager assetManager);
        Type GetAssetType();
    }
}
