using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine.Events;

namespace boardgames.attributes
{
	// Token: 0x02000165 RID: 357
	public class EntityViewProvideDataFromAttributeView : AttributeView
	{
		// Token: 0x06001218 RID: 4632 RVA: 0x000489F8 File Offset: 0x00046BF8
		// Note: this type is marked as 'beforefieldinit'.
		static EntityViewProvideDataFromAttributeView()
		{
			Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.attributes", "EntityViewProvideDataFromAttributeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr);
			EntityViewProvideDataFromAttributeView.NativeFieldInfoPtr_onHasEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr, "onHasEntityID");
			EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr, 100665944);
			EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr_GetView_Protected_Virtual_IAttributesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr, 100665945);
			EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr_ProvideData_Public_Virtual_Final_New_EntityComponent_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr, 100665946);
			EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr, 100665947);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00048A8C File Offset: 0x00046C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000620, XrefRangeEnd = 1000626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00048AC8 File Offset: 0x00046CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000626, XrefRangeEnd = 1000631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IAttributesProvider GetView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr_GetView_Protected_Virtual_IAttributesProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributesProvider>(intPtr3) : null;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x00048B14 File Offset: 0x00046D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000631, XrefRangeEnd = 1000637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EntityComponent ProvideData(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr_ProvideData_Public_Virtual_Final_New_EntityComponent_EntityInitializationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00048B64 File Offset: 0x00046D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000637, XrefRangeEnd = 1000645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityViewProvideDataFromAttributeView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityViewProvideDataFromAttributeView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityViewProvideDataFromAttributeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0000A75E File Offset: 0x0000895E
		public EntityViewProvideDataFromAttributeView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x00048BA0 File Offset: 0x00046DA0
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x0000A767 File Offset: 0x00008967
		public unsafe UnityEvent onHasEntityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewProvideDataFromAttributeView.NativeFieldInfoPtr_onHasEntityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityViewProvideDataFromAttributeView.NativeFieldInfoPtr_onHasEntityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeFieldInfoPtr_onHasEntityID;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_GetView_Protected_Virtual_IAttributesProvider_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Virtual_Final_New_EntityComponent_EntityInitializationContext_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
