using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000094 RID: 148
	public static class ScalableBufferManager : Object
	{
		// Token: 0x06000947 RID: 2375 RVA: 0x00034200 File Offset: 0x00032400
		// Note: this type is marked as 'beforefieldinit'.
		static ScalableBufferManager()
		{
			Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScalableBufferManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr);
			ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664353);
			ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664354);
			ScalableBufferManager.NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664355);
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0003426C File Offset: 0x0003246C
		public unsafe static float widthScaleFactor
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 649946, RefRangeEnd = 649955, XrefRangeStart = 649944, XrefRangeEnd = 649946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0003429C File Offset: 0x0003249C
		public unsafe static float heightScaleFactor
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 649957, RefRangeEnd = 649966, XrefRangeStart = 649955, XrefRangeEnd = 649957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x000342CC File Offset: 0x000324CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649966, XrefRangeEnd = 649968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ResizeBuffers(float widthScale, float heightScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref widthScale;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref heightScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0000584B File Offset: 0x00003A4B
		public ScalableBufferManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0;
	}
}
