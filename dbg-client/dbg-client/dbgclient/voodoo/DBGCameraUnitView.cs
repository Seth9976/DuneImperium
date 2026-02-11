using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace dbgclient.voodoo
{
	// Token: 0x02000086 RID: 134
	public class DBGCameraUnitView : UnitView
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x0002DE20 File Offset: 0x0002C020
		// Note: this type is marked as 'beforefieldinit'.
		static DBGCameraUnitView()
		{
			Il2CppClassPointerStore<DBGCameraUnitView>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.voodoo", "DBGCameraUnitView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGCameraUnitView>.NativeClassPtr);
			DBGCameraUnitView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCameraUnitView>.NativeClassPtr, 100664094);
			DBGCameraUnitView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCameraUnitView>.NativeClassPtr, 100664095);
			DBGCameraUnitView.NativeMethodInfoPtr_AllowPositionReinitialization_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCameraUnitView>.NativeClassPtr, 100664096);
			DBGCameraUnitView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGCameraUnitView>.NativeClassPtr, 100664097);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501605, XrefRangeEnd = 501609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitFromContext(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCameraUnitView.NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0002DEF0 File Offset: 0x0002C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501609, XrefRangeEnd = 501619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCameraUnitView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0002DF50 File Offset: 0x0002C150
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AllowPositionReinitialization()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGCameraUnitView.NativeMethodInfoPtr_AllowPositionReinitialization_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0002DF98 File Offset: 0x0002C198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 501619, XrefRangeEnd = 501620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGCameraUnitView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGCameraUnitView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGCameraUnitView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x000045CF File Offset: 0x000027CF
		public DBGCameraUnitView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_InitFromContext_Public_Virtual_Void_EntityInitializationContext_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_AllowPositionReinitialization_Public_Virtual_Boolean_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
