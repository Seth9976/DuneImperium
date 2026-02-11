using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public static class UISystemProfilerApi : Object
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00005900 File Offset: 0x00003B00
		// Note: this type is marked as 'beforefieldinit'.
		static UISystemProfilerApi()
		{
			Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIModule.dll", "UnityEngine", "UISystemProfilerApi");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr);
			UISystemProfilerApi.NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663445);
			UISystemProfilerApi.NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663446);
			UISystemProfilerApi.NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISystemProfilerApi>.NativeClassPtr, 100663447);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000596C File Offset: 0x00003B6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1257225, RefRangeEnd = 1257227, XrefRangeStart = 1257223, XrefRangeEnd = 1257225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginSample(UISystemProfilerApi.SampleType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000059A0 File Offset: 0x00003BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1257229, RefRangeEnd = 1257231, XrefRangeStart = 1257227, XrefRangeEnd = 1257229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndSample(UISystemProfilerApi.SampleType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000059D4 File Offset: 0x00003BD4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1257233, RefRangeEnd = 1257247, XrefRangeStart = 1257231, XrefRangeEnd = 1257233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddMarker(string name, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISystemProfilerApi.NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002133 File Offset: 0x00000333
		public UISystemProfilerApi(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_SampleType_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_SampleType_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_AddMarker_Public_Static_Void_String_Object_0;

		// Token: 0x0200000C RID: 12
		public enum SampleType
		{
			// Token: 0x040000AD RID: 173
			Layout,
			// Token: 0x040000AE RID: 174
			Render
		}
	}
}
