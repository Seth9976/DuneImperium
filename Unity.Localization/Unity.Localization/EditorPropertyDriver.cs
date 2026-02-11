using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization
{
	// Token: 0x02000018 RID: 24
	public static class EditorPropertyDriver : Object
	{
		// Token: 0x06000149 RID: 329 RVA: 0x0000E05C File Offset: 0x0000C25C
		// Note: this type is marked as 'beforefieldinit'.
		static EditorPropertyDriver()
		{
			Il2CppClassPointerStore<EditorPropertyDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization", "EditorPropertyDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EditorPropertyDriver>.NativeClassPtr);
			EditorPropertyDriver.NativeMethodInfoPtr_RegisterProperty_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPropertyDriver>.NativeClassPtr, 100663556);
			EditorPropertyDriver.NativeMethodInfoPtr_UnregisterProperty_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EditorPropertyDriver>.NativeClassPtr, 100663557);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterProperty(Object target, string propertyPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPropertyDriver.NativeMethodInfoPtr_RegisterProperty_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000E0FC File Offset: 0x0000C2FC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnregisterProperty(Object target, string propertyPath)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EditorPropertyDriver.NativeMethodInfoPtr_UnregisterProperty_Public_Static_Void_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000028B1 File Offset: 0x00000AB1
		public EditorPropertyDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_RegisterProperty_Public_Static_Void_Object_String_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterProperty_Public_Static_Void_Object_String_0;
	}
}
