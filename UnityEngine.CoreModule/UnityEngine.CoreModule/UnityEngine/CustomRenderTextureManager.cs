using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200008B RID: 139
	public static class CustomRenderTextureManager : Object
	{
		// Token: 0x060007BF RID: 1983 RVA: 0x0002FB28 File Offset: 0x0002DD28
		// Note: this type is marked as 'beforefieldinit'.
		static CustomRenderTextureManager()
		{
			Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTextureManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr);
			CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureLoaded");
			CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, "textureUnloaded");
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664255);
			CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664256);
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField = IL2CPP.ResolveICall<CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate>("UnityEngine.CustomRenderTextureManager::GetAllCustomRenderTextures");
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0002FBB8 File Offset: 0x0002DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649292, XrefRangeEnd = 649294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649294, XrefRangeEnd = 649296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00004EAC File Offset: 0x000030AC
		public CustomRenderTextureManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x0002FC28 File Offset: 0x0002DE28
		// (set) Token: 0x060007C4 RID: 1988 RVA: 0x00004EB5 File Offset: 0x000030B5
		public unsafe static Action<CustomRenderTexture> textureLoaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x0002FC50 File Offset: 0x0002DE50
		// (set) Token: 0x060007C6 RID: 1990 RVA: 0x00004EC7 File Offset: 0x000030C7
		public unsafe static Action<CustomRenderTexture> textureUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CustomRenderTexture>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00004ED9 File Offset: 0x000030D9
		public static void add_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00004EE6 File Offset: 0x000030E6
		public static void remove_textureLoaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00004EF3 File Offset: 0x000030F3
		public static void add_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00004F00 File Offset: 0x00003100
		public static void remove_textureUnloaded(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00004F0D File Offset: 0x0000310D
		public static void GetAllCustomRenderTextures(List<CustomRenderTexture> currentCustomRenderTextures)
		{
			CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(currentCustomRenderTextures));
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00004F1F File Offset: 0x0000311F
		public static void add_updateTriggered(Action<CustomRenderTexture, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00004F2C File Offset: 0x0000312C
		public static void remove_updateTriggered(Action<CustomRenderTexture, int> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00004F39 File Offset: 0x00003139
		public static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00004F46 File Offset: 0x00003146
		public static void add_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00004F53 File Offset: 0x00003153
		public static void remove_initializeTriggered(Action<CustomRenderTexture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00004F60 File Offset: 0x00003160
		public static void InvokeTriggerInitialize(CustomRenderTexture crt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeFieldInfoPtr_textureLoaded;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr_textureUnloaded;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0;

		// Token: 0x04000660 RID: 1632
		private static readonly CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate GetAllCustomRenderTexturesDelegateField;

		// Token: 0x020004BB RID: 1211
		// (Invoke) Token: 0x06003282 RID: 12930
		private delegate void GetAllCustomRenderTexturesDelegate(IntPtr currentCustomRenderTextures);
	}
}
