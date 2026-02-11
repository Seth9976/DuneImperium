using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200007D RID: 125
	[Serializable]
	public class UnitPosition : global::Il2CppSystem.Object
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x00021C04 File Offset: 0x0001FE04
		// Note: this type is marked as 'beforefieldinit'.
		static UnitPosition()
		{
			Il2CppClassPointerStore<UnitPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "UnitPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr);
			UnitPosition.NativeFieldInfoPtr_Requester = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, "Requester");
			UnitPosition.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, "Position");
			UnitPosition.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, "Parent");
			UnitPosition.NativeFieldInfoPtr_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, "Show");
			UnitPosition.NativeFieldInfoPtr_MoveLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, "MoveLayer");
			UnitPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, 100664291);
			UnitPosition.NativeMethodInfoPtr_Init_Public_Void_Object_LocalTransform_Transform_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, 100664292);
			UnitPosition.NativeMethodInfoPtr_GetInfo_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, 100664293);
			UnitPosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr, 100664294);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00021CE8 File Offset: 0x0001FEE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1114243, RefRangeEnd = 1114245, XrefRangeStart = 1114242, XrefRangeEnd = 1114243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitPosition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00021D24 File Offset: 0x0001FF24
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1114247, RefRangeEnd = 1114254, XrefRangeStart = 1114245, XrefRangeEnd = 1114247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(global::Il2CppSystem.Object r, LocalTransform p, Transform parent, int ml, bool s = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ml;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref s;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPosition.NativeMethodInfoPtr_Init_Public_Void_Object_LocalTransform_Transform_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00021DA4 File Offset: 0x0001FFA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1114288, RefRangeEnd = 1114291, XrefRangeStart = 1114254, XrefRangeEnd = 1114288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitPosition.NativeMethodInfoPtr_GetInfo_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00021DDC File Offset: 0x0001FFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114291, XrefRangeEnd = 1114297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnitPosition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00005A5C File Offset: 0x00003C5C
		public UnitPosition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x00021E20 File Offset: 0x00020020
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00005A65 File Offset: 0x00003C65
		public unsafe global::Il2CppSystem.Object Requester
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Requester);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Requester), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00021E50 File Offset: 0x00020050
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x00005A84 File Offset: 0x00003C84
		public unsafe LocalTransform Position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Position)) = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00021E78 File Offset: 0x00020078
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00005A9F File Offset: 0x00003C9F
		public unsafe Transform Parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00021EA8 File Offset: 0x000200A8
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00005ABE File Offset: 0x00003CBE
		public unsafe bool Show
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Show);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_Show)) = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00021ED0 File Offset: 0x000200D0
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x00005AD9 File Offset: 0x00003CD9
		public unsafe int MoveLayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_MoveLayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitPosition.NativeFieldInfoPtr_MoveLayer)) = value;
			}
		}

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_Requester;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_Position;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_Parent;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_Show;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_MoveLayer;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Object_LocalTransform_Transform_Int32_Boolean_0;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeMethodInfoPtr_GetInfo_Public_String_0;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
