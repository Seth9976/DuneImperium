using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000106 RID: 262
	public class XRPassUniversal : XRPass
	{
		// Token: 0x06001610 RID: 5648 RVA: 0x0005E95C File Offset: 0x0005CB5C
		// Note: this type is marked as 'beforefieldinit'.
		static XRPassUniversal()
		{
			Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "XRPassUniversal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr);
			XRPassUniversal.NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, "<isLateLatchEnabled>k__BackingField");
			XRPassUniversal.NativeFieldInfoPtr__canMarkLateLatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, "<canMarkLateLatch>k__BackingField");
			XRPassUniversal.NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, "<hasMarkedLateLatch>k__BackingField");
			XRPassUniversal.NativeMethodInfoPtr_Create_Public_Static_XRPass_XRPassCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665835);
			XRPassUniversal.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665836);
			XRPassUniversal.NativeMethodInfoPtr_get_isLateLatchEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665837);
			XRPassUniversal.NativeMethodInfoPtr_set_isLateLatchEnabled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665838);
			XRPassUniversal.NativeMethodInfoPtr_get_canMarkLateLatch_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665839);
			XRPassUniversal.NativeMethodInfoPtr_set_canMarkLateLatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665840);
			XRPassUniversal.NativeMethodInfoPtr_get_hasMarkedLateLatch_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665841);
			XRPassUniversal.NativeMethodInfoPtr_set_hasMarkedLateLatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665842);
			XRPassUniversal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100665843);
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0005EA7C File Offset: 0x0005CC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622878, XrefRangeEnd = 622886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XRPass Create(XRPassCreateInfo createInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(createInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr_Create_Public_Static_XRPass_XRPassCreateInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XRPass>(intPtr3) : null;
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x0005EAC8 File Offset: 0x0005CCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622886, XrefRangeEnd = 622892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XRPassUniversal.NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x0005EB04 File Offset: 0x0005CD04
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x0005EB40 File Offset: 0x0005CD40
		public unsafe bool isLateLatchEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr_get_isLateLatchEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr_set_isLateLatchEnabled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x0005EB80 File Offset: 0x0005CD80
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x0005EBBC File Offset: 0x0005CDBC
		public unsafe bool canMarkLateLatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr_get_canMarkLateLatch_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr_set_canMarkLateLatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x0005EBFC File Offset: 0x0005CDFC
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x0005EC38 File Offset: 0x0005CE38
		public unsafe bool hasMarkedLateLatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr_get_hasMarkedLateLatch_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr_set_hasMarkedLateLatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0005EC78 File Offset: 0x0005CE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 622892, XrefRangeEnd = 622893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRPassUniversal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRPassUniversal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0000CDED File Offset: 0x0000AFED
		public XRPassUniversal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x0005ECB4 File Offset: 0x0005CEB4
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x0000CDF6 File Offset: 0x0000AFF6
		public unsafe bool _isLateLatchEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassUniversal.NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassUniversal.NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x0005ECDC File Offset: 0x0005CEDC
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x0000CE11 File Offset: 0x0000B011
		public unsafe bool _canMarkLateLatch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassUniversal.NativeFieldInfoPtr__canMarkLateLatch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassUniversal.NativeFieldInfoPtr__canMarkLateLatch_k__BackingField)) = value;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0005ED04 File Offset: 0x0005CF04
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x0000CE2C File Offset: 0x0000B02C
		public unsafe bool _hasMarkedLateLatch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassUniversal.NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRPassUniversal.NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField)) = value;
			}
		}

		// Token: 0x04001006 RID: 4102
		private static readonly IntPtr NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField;

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr__canMarkLateLatch_k__BackingField;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XRPass_XRPassCreateInfo_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

		// Token: 0x0400100B RID: 4107
		private static readonly IntPtr NativeMethodInfoPtr_get_isLateLatchEnabled_Internal_get_Boolean_0;

		// Token: 0x0400100C RID: 4108
		private static readonly IntPtr NativeMethodInfoPtr_set_isLateLatchEnabled_Internal_set_Void_Boolean_0;

		// Token: 0x0400100D RID: 4109
		private static readonly IntPtr NativeMethodInfoPtr_get_canMarkLateLatch_Internal_get_Boolean_0;

		// Token: 0x0400100E RID: 4110
		private static readonly IntPtr NativeMethodInfoPtr_set_canMarkLateLatch_Internal_set_Void_Boolean_0;

		// Token: 0x0400100F RID: 4111
		private static readonly IntPtr NativeMethodInfoPtr_get_hasMarkedLateLatch_Internal_get_Boolean_0;

		// Token: 0x04001010 RID: 4112
		private static readonly IntPtr NativeMethodInfoPtr_set_hasMarkedLateLatch_Internal_set_Void_Boolean_0;

		// Token: 0x04001011 RID: 4113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
