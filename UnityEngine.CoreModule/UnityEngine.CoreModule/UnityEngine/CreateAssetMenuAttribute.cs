using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000127 RID: 295
	public sealed class CreateAssetMenuAttribute : Attribute
	{
		// Token: 0x06001783 RID: 6019 RVA: 0x0006FB3C File Offset: 0x0006DD3C
		// Note: this type is marked as 'beforefieldinit'.
		static CreateAssetMenuAttribute()
		{
			Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CreateAssetMenuAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr);
			CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<menuName>k__BackingField");
			CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<fileName>k__BackingField");
			CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, "<order>k__BackingField");
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100666518);
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100666519);
			CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100666520);
			CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr, 100666521);
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x000094B8 File Offset: 0x000076B8
		// (set) Token: 0x06001784 RID: 6020 RVA: 0x0006FBF8 File Offset: 0x0006DDF8
		public unsafe string menuName
		{
			get
			{
				return this._menuName_k__BackingField;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x000094C0 File Offset: 0x000076C0
		// (set) Token: 0x06001785 RID: 6021 RVA: 0x0006FC3C File Offset: 0x0006DE3C
		public unsafe string fileName
		{
			get
			{
				return this._fileName_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x000094C8 File Offset: 0x000076C8
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x0006FC80 File Offset: 0x0006DE80
		public unsafe int order
		{
			get
			{
				return this._order_k__BackingField;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0006FCC0 File Offset: 0x0006DEC0
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateAssetMenuAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateAssetMenuAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateAssetMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00009456 File Offset: 0x00007656
		public CreateAssetMenuAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x0006FCFC File Offset: 0x0006DEFC
		// (set) Token: 0x0600178A RID: 6026 RVA: 0x0000945F File Offset: 0x0000765F
		public unsafe string _menuName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__menuName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x0006FD24 File Offset: 0x0006DF24
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x0000947E File Offset: 0x0000767E
		public unsafe string _fileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__fileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0006FD4C File Offset: 0x0006DF4C
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x0000949D File Offset: 0x0000769D
		public unsafe int _order_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateAssetMenuAttribute.NativeFieldInfoPtr__order_k__BackingField)) = value;
			}
		}

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeFieldInfoPtr__menuName_k__BackingField;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeFieldInfoPtr__fileName_k__BackingField;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeFieldInfoPtr__order_k__BackingField;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_set_menuName_Public_set_Void_String_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_set_fileName_Public_set_Void_String_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_set_order_Public_set_Void_Int32_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
