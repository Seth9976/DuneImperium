using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023B RID: 571
	[StructLayout(2)]
	public struct RendererList
	{
		// Token: 0x06002629 RID: 9769 RVA: 0x000A1F64 File Offset: 0x000A0164
		// Note: this type is marked as 'beforefieldinit'.
		static RendererList()
		{
			Il2CppClassPointerStore<RendererList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RendererList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererList>.NativeClassPtr);
			RendererList.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "context");
			RendererList.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "index");
			RendererList.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "frame");
			RendererList.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "type");
			RendererList.NativeFieldInfoPtr_nullRendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, "nullRendererList");
			RendererList.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100668190);
			RendererList.NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100668191);
			RendererList.NativeMethodInfoPtr_get_isValid_Injected_Private_Static_Boolean_byref_RendererList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100668193);
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x000A2034 File Offset: 0x000A0234
		public unsafe bool isValid
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 683790, RefRangeEnd = 683793, XrefRangeStart = 683785, XrefRangeEnd = 683790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000A2064 File Offset: 0x000A0264
		[CallerCount(0)]
		public unsafe RendererList(UIntPtr ctx, uint indx)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ctx;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000A20A4 File Offset: 0x000A02A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683793, XrefRangeEnd = 683795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool get_isValid_Injected(ref RendererList _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr_get_isValid_Injected_Private_Static_Boolean_byref_RendererList_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x0000EF25 File Offset: 0x0000D125
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererList>.NativeClassPtr, ref this));
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x000A20E4 File Offset: 0x000A02E4
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x0000EF37 File Offset: 0x0000D137
		public unsafe static RendererList nullRendererList
		{
			get
			{
				RendererList rendererList;
				IL2CPP.il2cpp_field_static_get_value(RendererList.NativeFieldInfoPtr_nullRendererList, (void*)(&rendererList));
				return rendererList;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererList.NativeFieldInfoPtr_nullRendererList, (void*)(&value));
			}
		}

		// Token: 0x0400222D RID: 8749
		private static readonly IntPtr NativeFieldInfoPtr_context;

		// Token: 0x0400222E RID: 8750
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400222F RID: 8751
		private static readonly IntPtr NativeFieldInfoPtr_frame;

		// Token: 0x04002230 RID: 8752
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04002231 RID: 8753
		private static readonly IntPtr NativeFieldInfoPtr_nullRendererList;

		// Token: 0x04002232 RID: 8754
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;

		// Token: 0x04002233 RID: 8755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0;

		// Token: 0x04002234 RID: 8756
		private static readonly IntPtr NativeMethodInfoPtr_get_isValid_Injected_Private_Static_Boolean_byref_RendererList_0;

		// Token: 0x04002235 RID: 8757
		[FieldOffset(0)]
		public UIntPtr context;

		// Token: 0x04002236 RID: 8758
		[FieldOffset(8)]
		public uint index;

		// Token: 0x04002237 RID: 8759
		[FieldOffset(12)]
		public uint frame;

		// Token: 0x04002238 RID: 8760
		[FieldOffset(16)]
		public uint type;
	}
}
