using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000087 RID: 135
	[StructLayout(2)]
	public struct BuddyAllocation
	{
		// Token: 0x06000C35 RID: 3125 RVA: 0x00040448 File Offset: 0x0003E648
		// Note: this type is marked as 'beforefieldinit'.
		static BuddyAllocation()
		{
			Il2CppClassPointerStore<BuddyAllocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "BuddyAllocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuddyAllocation>.NativeClassPtr);
			BuddyAllocation.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocation>.NativeClassPtr, "level");
			BuddyAllocation.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuddyAllocation>.NativeClassPtr, "index");
			BuddyAllocation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocation>.NativeClassPtr, 100664960);
			BuddyAllocation.NativeMethodInfoPtr_get_index2D_Public_get_uint2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuddyAllocation>.NativeClassPtr, 100664961);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000404C8 File Offset: 0x0003E6C8
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuddyAllocation(int level, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00040508 File Offset: 0x0003E708
		public unsafe uint2 index2D
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611689, XrefRangeEnd = 611690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuddyAllocation.NativeMethodInfoPtr_get_index2D_Public_get_uint2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00007875 File Offset: 0x00005A75
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuddyAllocation>.NativeClassPtr, ref this));
		}

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeFieldInfoPtr_level;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000909 RID: 2313
		private static readonly IntPtr NativeMethodInfoPtr_get_index2D_Public_get_uint2_0;

		// Token: 0x0400090A RID: 2314
		[FieldOffset(0)]
		public int level;

		// Token: 0x0400090B RID: 2315
		[FieldOffset(4)]
		public int index;
	}
}
