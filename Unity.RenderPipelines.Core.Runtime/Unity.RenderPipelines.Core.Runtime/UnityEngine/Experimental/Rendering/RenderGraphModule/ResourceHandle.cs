using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	// Token: 0x02000029 RID: 41
	[StructLayout(2)]
	public struct ResourceHandle
	{
		// Token: 0x0600039F RID: 927 RVA: 0x0001B338 File Offset: 0x00019538
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceHandle()
		{
			Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering.RenderGraphModule", "ResourceHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr);
			ResourceHandle.NativeFieldInfoPtr_kValidityMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, "kValidityMask");
			ResourceHandle.NativeFieldInfoPtr_kIndexMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, "kIndexMask");
			ResourceHandle.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, "m_Value");
			ResourceHandle.NativeFieldInfoPtr_s_CurrentValidBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, "s_CurrentValidBit");
			ResourceHandle.NativeFieldInfoPtr_s_SharedResourceValidBit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, "s_SharedResourceValidBit");
			ResourceHandle.NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, "<type>k__BackingField");
			ResourceHandle.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663776);
			ResourceHandle.NativeMethodInfoPtr_get_type_Public_get_RenderGraphResourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663777);
			ResourceHandle.NativeMethodInfoPtr_set_type_Private_set_Void_RenderGraphResourceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663778);
			ResourceHandle.NativeMethodInfoPtr_get_iType_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663779);
			ResourceHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RenderGraphResourceType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663780);
			ResourceHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ResourceHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663781);
			ResourceHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663782);
			ResourceHandle.NativeMethodInfoPtr_NewFrame_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, 100663783);
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0001B480 File Offset: 0x00019680
		public unsafe int index
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 638989, RefRangeEnd = 639002, XrefRangeStart = 638989, XrefRangeEnd = 639002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr_get_index_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0001B4B0 File Offset: 0x000196B0
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x0001B4E0 File Offset: 0x000196E0
		public unsafe RenderGraphResourceType type
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr_get_type_Public_get_RenderGraphResourceType_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr_set_type_Private_set_Void_RenderGraphResourceType_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0001B514 File Offset: 0x00019714
		public unsafe int iType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958429, XrefRangeEnd = 958432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr_get_iType_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0001B544 File Offset: 0x00019744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 958441, RefRangeEnd = 958443, XrefRangeStart = 958432, XrefRangeEnd = 958441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceHandle(int value, RenderGraphResourceType type, bool shared)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shared;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr__ctor_Internal_Void_Int32_RenderGraphResourceType_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001B594 File Offset: 0x00019794
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 958446, RefRangeEnd = 958460, XrefRangeStart = 958443, XrefRangeEnd = 958446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(ResourceHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ResourceHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0001B5D4 File Offset: 0x000197D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 958461, RefRangeEnd = 958475, XrefRangeStart = 958460, XrefRangeEnd = 958461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0001B604 File Offset: 0x00019804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958475, XrefRangeEnd = 958484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NewFrame(int executionIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceHandle.NativeMethodInfoPtr_NewFrame_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000371F File Offset: 0x0000191F
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResourceHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x0001B638 File Offset: 0x00019838
		// (set) Token: 0x060003AA RID: 938 RVA: 0x00003731 File Offset: 0x00001931
		public unsafe static uint kValidityMask
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ResourceHandle.NativeFieldInfoPtr_kValidityMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceHandle.NativeFieldInfoPtr_kValidityMask, (void*)(&value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003AB RID: 939 RVA: 0x0001B654 File Offset: 0x00019854
		// (set) Token: 0x060003AC RID: 940 RVA: 0x0000373F File Offset: 0x0000193F
		public unsafe static uint kIndexMask
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ResourceHandle.NativeFieldInfoPtr_kIndexMask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceHandle.NativeFieldInfoPtr_kIndexMask, (void*)(&value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0001B670 File Offset: 0x00019870
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000374D File Offset: 0x0000194D
		public unsafe static uint s_CurrentValidBit
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ResourceHandle.NativeFieldInfoPtr_s_CurrentValidBit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceHandle.NativeFieldInfoPtr_s_CurrentValidBit, (void*)(&value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0001B68C File Offset: 0x0001988C
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0000375B File Offset: 0x0000195B
		public unsafe static uint s_SharedResourceValidBit
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ResourceHandle.NativeFieldInfoPtr_s_SharedResourceValidBit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceHandle.NativeFieldInfoPtr_s_SharedResourceValidBit, (void*)(&value));
			}
		}

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_kValidityMask;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_kIndexMask;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentValidBit;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_s_SharedResourceValidBit;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr__type_k__BackingField;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_RenderGraphResourceType_0;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Private_set_Void_RenderGraphResourceType_0;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeMethodInfoPtr_get_iType_Public_get_Int32_0;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_RenderGraphResourceType_Boolean_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ResourceHandle_0;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr_NewFrame_Public_Static_Void_Int32_0;

		// Token: 0x0400029D RID: 669
		[FieldOffset(0)]
		public uint m_Value;

		// Token: 0x0400029E RID: 670
		[FieldOffset(4)]
		public RenderGraphResourceType _type_k__BackingField;
	}
}
