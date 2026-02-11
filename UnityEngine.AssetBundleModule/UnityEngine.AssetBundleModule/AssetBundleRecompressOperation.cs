using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class AssetBundleRecompressOperation : AsyncOperation
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00003438 File Offset: 0x00001638
		// Note: this type is marked as 'beforefieldinit'.
		static AssetBundleRecompressOperation()
		{
			Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AssetBundleModule.dll", "UnityEngine", "AssetBundleRecompressOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetBundleRecompressOperation>.NativeClassPtr);
			AssetBundleRecompressOperation.get_humanReadableResultDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_humanReadableResultDelegate>("UnityEngine.AssetBundleRecompressOperation::get_humanReadableResult");
			AssetBundleRecompressOperation.get_inputPathDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_inputPathDelegate>("UnityEngine.AssetBundleRecompressOperation::get_inputPath");
			AssetBundleRecompressOperation.get_outputPathDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_outputPathDelegate>("UnityEngine.AssetBundleRecompressOperation::get_outputPath");
			AssetBundleRecompressOperation.get_resultDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_resultDelegate>("UnityEngine.AssetBundleRecompressOperation::get_result");
			AssetBundleRecompressOperation.get_successDelegateField = IL2CPP.ResolveICall<AssetBundleRecompressOperation.get_successDelegate>("UnityEngine.AssetBundleRecompressOperation::get_success");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000020D7 File Offset: 0x000002D7
		public AssetBundleRecompressOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000034B4 File Offset: 0x000016B4
		public string humanReadableResult
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_humanReadableResultDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000034D8 File Offset: 0x000016D8
		public string inputPath
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_inputPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000034FC File Offset: 0x000016FC
		public string outputPath
		{
			get
			{
				IntPtr intPtr = AssetBundleRecompressOperation.get_outputPathDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000020E0 File Offset: 0x000002E0
		public AssetBundleLoadResult result
		{
			get
			{
				return AssetBundleRecompressOperation.get_resultDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000020F2 File Offset: 0x000002F2
		public bool success
		{
			get
			{
				return AssetBundleRecompressOperation.get_successDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0400002D RID: 45
		private static readonly AssetBundleRecompressOperation.get_humanReadableResultDelegate get_humanReadableResultDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly AssetBundleRecompressOperation.get_inputPathDelegate get_inputPathDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly AssetBundleRecompressOperation.get_outputPathDelegate get_outputPathDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly AssetBundleRecompressOperation.get_resultDelegate get_resultDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly AssetBundleRecompressOperation.get_successDelegate get_successDelegateField;

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600008E RID: 142
		private delegate IntPtr get_humanReadableResultDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000090 RID: 144
		private delegate IntPtr get_inputPathDelegate(IntPtr @this);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000092 RID: 146
		private delegate IntPtr get_outputPathDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000094 RID: 148
		private delegate AssetBundleLoadResult get_resultDelegate(IntPtr @this);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000096 RID: 150
		private delegate bool get_successDelegate(IntPtr @this);
	}
}
