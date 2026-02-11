using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.platform
{
	// Token: 0x020000E2 RID: 226
	public class SaveNoop : Object
	{
		// Token: 0x06000DB5 RID: 3509 RVA: 0x00049478 File Offset: 0x00047678
		// Note: this type is marked as 'beforefieldinit'.
		static SaveNoop()
		{
			Il2CppClassPointerStore<SaveNoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.platform", "SaveNoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr);
			SaveNoop.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr, "Instance");
			SaveNoop.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr, 100665266);
			SaveNoop.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr, 100665267);
			SaveNoop.NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr, 100665268);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x000494F8 File Offset: 0x000476F8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveNoop()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveNoop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveNoop.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00049534 File Offset: 0x00047734
		public unsafe virtual bool Completed
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveNoop.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00049570 File Offset: 0x00047770
		public unsafe virtual bool Success
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveNoop.NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00006B95 File Offset: 0x00004D95
		public SaveNoop(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x000495AC File Offset: 0x000477AC
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00006B9E File Offset: 0x00004D9E
		public unsafe static SaveNoop Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SaveNoop.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveNoop>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveNoop.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0;
	}
}
