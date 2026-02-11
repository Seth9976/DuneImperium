using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.VirtualTexturing
{
	// Token: 0x02000003 RID: 3
	public static class EditorHelpers
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002135 File Offset: 0x00000335
		public static int tileSize
		{
			get
			{
				return EditorHelpers.get_tileSizeDelegateField();
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002368 File Offset: 0x00000568
		public unsafe static bool ValidateTextureStack(Il2CppReferenceArray<Texture> textures, out string errorMessage)
		{
			EditorHelpers.ValidateTextureStackDelegate validateTextureStackDelegateField = EditorHelpers.ValidateTextureStackDelegateField;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(textures);
			IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			return validateTextureStackDelegateField(intPtr, &intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002390 File Offset: 0x00000590
		public static Il2CppStructArray<GraphicsFormat> QuerySupportedFormats()
		{
			IntPtr intPtr = EditorHelpers.QuerySupportedFormatsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<GraphicsFormat>>(intPtr2) : null;
		}

		// Token: 0x04000006 RID: 6
		private static readonly EditorHelpers.get_tileSizeDelegate get_tileSizeDelegateField = IL2CPP.ResolveICall<EditorHelpers.get_tileSizeDelegate>("UnityEngine.Rendering.VirtualTexturing.EditorHelpers::get_tileSize");

		// Token: 0x04000007 RID: 7
		private static readonly EditorHelpers.ValidateTextureStackDelegate ValidateTextureStackDelegateField = IL2CPP.ResolveICall<EditorHelpers.ValidateTextureStackDelegate>("UnityEngine.Rendering.VirtualTexturing.EditorHelpers::ValidateTextureStack");

		// Token: 0x04000008 RID: 8
		private static readonly EditorHelpers.QuerySupportedFormatsDelegate QuerySupportedFormatsDelegateField = IL2CPP.ResolveICall<EditorHelpers.QuerySupportedFormatsDelegate>("UnityEngine.Rendering.VirtualTexturing.EditorHelpers::QuerySupportedFormats");

		// Token: 0x0200000E RID: 14
		// (Invoke) Token: 0x0600003D RID: 61
		private delegate int get_tileSizeDelegate();

		// Token: 0x0200000F RID: 15
		// (Invoke) Token: 0x0600003F RID: 63
		private delegate bool ValidateTextureStackDelegate(IntPtr textures, [Out] IntPtr errorMessage);

		// Token: 0x02000010 RID: 16
		// (Invoke) Token: 0x06000041 RID: 65
		private delegate IntPtr QuerySupportedFormatsDelegate();
	}
}
