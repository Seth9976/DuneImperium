using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro
{
	// Token: 0x0200001F RID: 31
	[Serializable]
	public class TMP_Asset : ScriptableObject
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0001369C File Offset: 0x0001189C
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Asset()
		{
			Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Asset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr);
			TMP_Asset.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "m_InstanceID");
			TMP_Asset.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "hashCode");
			TMP_Asset.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "material");
			TMP_Asset.NativeFieldInfoPtr_materialHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, "materialHashCode");
			TMP_Asset.NativeMethodInfoPtr_get_instanceID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, 100663583);
			TMP_Asset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr, 100663584);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00013744 File Offset: 0x00011944
		public unsafe int instanceID
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1038023, RefRangeEnd = 1038035, XrefRangeStart = 1038022, XrefRangeEnd = 1038023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Asset.NativeMethodInfoPtr_get_instanceID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00013780 File Offset: 0x00011980
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_Asset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_Asset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Asset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00003768 File Offset: 0x00001968
		public TMP_Asset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x000137BC File Offset: 0x000119BC
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00003771 File Offset: 0x00001971
		public unsafe int m_InstanceID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_m_InstanceID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_m_InstanceID)) = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002FA RID: 762 RVA: 0x000137E4 File Offset: 0x000119E4
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0000378C File Offset: 0x0000198C
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0001380C File Offset: 0x00011A0C
		// (set) Token: 0x060002FD RID: 765 RVA: 0x000037A7 File Offset: 0x000019A7
		public unsafe Material material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001383C File Offset: 0x00011A3C
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000037C6 File Offset: 0x000019C6
		public unsafe int materialHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_materialHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_Asset.NativeFieldInfoPtr_materialHashCode)) = value;
			}
		}

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_m_InstanceID;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_material;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_materialHashCode;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_get_instanceID_Public_get_Int32_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
