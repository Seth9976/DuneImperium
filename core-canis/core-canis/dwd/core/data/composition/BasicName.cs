using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.data.composition
{
	// Token: 0x020001DB RID: 475
	public class BasicName : NameLookup
	{
		// Token: 0x06001A2B RID: 6699 RVA: 0x0007C0DC File Offset: 0x0007A2DC
		// Note: this type is marked as 'beforefieldinit'.
		static BasicName()
		{
			Il2CppClassPointerStore<BasicName>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.composition", "BasicName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicName>.NativeClassPtr);
			BasicName.NativeFieldInfoPtr_basicName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicName>.NativeClassPtr, "basicName");
			BasicName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicName>.NativeClassPtr, 100667443);
			BasicName.NativeMethodInfoPtr_name_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicName>.NativeClassPtr, 100667444);
			BasicName.NativeMethodInfoPtr_SetName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicName>.NativeClassPtr, 100667445);
			BasicName.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicName>.NativeClassPtr, 100667446);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0007C170 File Offset: 0x0007A370
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 882424, RefRangeEnd = 882479, XrefRangeStart = 882419, XrefRangeEnd = 882424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicName(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0007C1BC File Offset: 0x0007A3BC
		[CallerCount(0)]
		public unsafe override string name()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicName.NativeMethodInfoPtr_name_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0007C200 File Offset: 0x0007A400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 882480, RefRangeEnd = 882482, XrefRangeStart = 882479, XrefRangeEnd = 882480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicName.NativeMethodInfoPtr_SetName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0007C244 File Offset: 0x0007A444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 882482, XrefRangeEnd = 882490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DataComponent Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BasicName.NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComponent>(intPtr3) : null;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0000B602 File Offset: 0x00009802
		public BasicName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x0007C290 File Offset: 0x0007A490
		// (set) Token: 0x06001A32 RID: 6706 RVA: 0x0000B60B File Offset: 0x0000980B
		public unsafe string basicName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicName.NativeFieldInfoPtr_basicName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicName.NativeFieldInfoPtr_basicName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeFieldInfoPtr_basicName;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_name_Protected_Virtual_String_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Public_Void_String_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_DataComponent_0;
	}
}
