using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000106 RID: 262
	public class ToolboxItemAttribute : Attribute
	{
		// Token: 0x06001065 RID: 4197 RVA: 0x0005A384 File Offset: 0x00058584
		// Note: this type is marked as 'beforefieldinit'.
		static ToolboxItemAttribute()
		{
			Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ToolboxItemAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr);
			ToolboxItemAttribute.NativeFieldInfoPtr__toolboxItemTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, "_toolboxItemTypeName");
			ToolboxItemAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, "Default");
			ToolboxItemAttribute.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, "None");
			ToolboxItemAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, 100665667);
			ToolboxItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, 100665668);
			ToolboxItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, 100665669);
			ToolboxItemAttribute.NativeMethodInfoPtr_get_ToolboxItemTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, 100665670);
			ToolboxItemAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, 100665671);
			ToolboxItemAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr, 100665672);
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0005A468 File Offset: 0x00058668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458875, XrefRangeEnd = 458902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToolboxItemAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0005A4B0 File Offset: 0x000586B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458902, XrefRangeEnd = 458907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToolboxItemAttribute(bool defaultType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref defaultType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0005A4F8 File Offset: 0x000586F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458907, XrefRangeEnd = 458915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToolboxItemAttribute(string toolboxItemTypeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToolboxItemAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(toolboxItemTypeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x0005A544 File Offset: 0x00058744
		public unsafe string ToolboxItemTypeName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458915, XrefRangeEnd = 458916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToolboxItemAttribute.NativeMethodInfoPtr_get_ToolboxItemTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0005A57C File Offset: 0x0005877C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458916, XrefRangeEnd = 458925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToolboxItemAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x0005A5D4 File Offset: 0x000587D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 458925, XrefRangeEnd = 458927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToolboxItemAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00007D7B File Offset: 0x00005F7B
		public ToolboxItemAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x0005A61C File Offset: 0x0005881C
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x00007D84 File Offset: 0x00005F84
		public unsafe string _toolboxItemTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxItemAttribute.NativeFieldInfoPtr__toolboxItemTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToolboxItemAttribute.NativeFieldInfoPtr__toolboxItemTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x0005A644 File Offset: 0x00058844
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public unsafe static ToolboxItemAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ToolboxItemAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToolboxItemAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ToolboxItemAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0005A66C File Offset: 0x0005886C
		// (set) Token: 0x06001072 RID: 4210 RVA: 0x00007DB5 File Offset: 0x00005FB5
		public unsafe static ToolboxItemAttribute None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ToolboxItemAttribute.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToolboxItemAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ToolboxItemAttribute.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeFieldInfoPtr__toolboxItemTypeName;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_get_ToolboxItemTypeName_Public_get_String_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
