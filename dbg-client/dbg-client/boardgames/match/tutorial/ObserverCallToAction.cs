using System;
using Canis.attributes;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using lotus;

namespace boardgames.match.tutorial
{
	// Token: 0x02000257 RID: 599
	public class ObserverCallToAction : Observer
	{
		// Token: 0x06001B3D RID: 6973 RVA: 0x00076678 File Offset: 0x00074878
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverCallToAction()
		{
			Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.tutorial", "ObserverCallToAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr);
			ObserverCallToAction.NativeFieldInfoPtr_registeredIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, "registeredIdentifier");
			ObserverCallToAction.NativeFieldInfoPtr_tutorialEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, "tutorialEffects");
			ObserverCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667657);
			ObserverCallToAction.NativeMethodInfoPtr_RunAction_Public_Abstract_Virtual_New_IEnumerator_MutableAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667658);
			ObserverCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Abstract_Virtual_New_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667659);
			ObserverCallToAction.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667660);
			ObserverCallToAction.NativeMethodInfoPtr_UpdateRegistration_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667661);
			ObserverCallToAction.NativeMethodInfoPtr_IsRegistered_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667662);
			ObserverCallToAction.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667663);
			ObserverCallToAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr, 100667664);
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x00076770 File Offset: 0x00074970
		public unsafe virtual string Identifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverCallToAction.NativeMethodInfoPtr_get_Identifier_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000767B4 File Offset: 0x000749B4
		[CallerCount(0)]
		public unsafe virtual IEnumerator RunAction(MutableAttributes attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverCallToAction.NativeMethodInfoPtr_RunAction_Public_Abstract_Virtual_New_IEnumerator_MutableAttributes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00076810 File Offset: 0x00074A10
		[CallerCount(0)]
		public unsafe virtual Command GetPersistentTutorialEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverCallToAction.NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Abstract_Virtual_New_Command_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0007685C File Offset: 0x00074A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533055, XrefRangeEnd = 533056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverCallToAction.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00076890 File Offset: 0x00074A90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 533061, RefRangeEnd = 533066, XrefRangeStart = 533056, XrefRangeEnd = 533061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRegistration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverCallToAction.NativeMethodInfoPtr_UpdateRegistration_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000768C4 File Offset: 0x00074AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533066, XrefRangeEnd = 533067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRegistered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverCallToAction.NativeMethodInfoPtr_IsRegistered_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00076900 File Offset: 0x00074B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 533067, XrefRangeEnd = 533072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverCallToAction.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00076934 File Offset: 0x00074B34
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverCallToAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverCallToAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverCallToAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0000ED00 File Offset: 0x0000CF00
		public ObserverCallToAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x00076970 File Offset: 0x00074B70
		// (set) Token: 0x06001B48 RID: 6984 RVA: 0x0000ED09 File Offset: 0x0000CF09
		public unsafe string registeredIdentifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCallToAction.NativeFieldInfoPtr_registeredIdentifier);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCallToAction.NativeFieldInfoPtr_registeredIdentifier), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001B49 RID: 6985 RVA: 0x00076998 File Offset: 0x00074B98
		// (set) Token: 0x06001B4A RID: 6986 RVA: 0x0000ED28 File Offset: 0x0000CF28
		public unsafe TutorialEffects tutorialEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCallToAction.NativeFieldInfoPtr_tutorialEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TutorialEffects>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverCallToAction.NativeFieldInfoPtr_tutorialEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeFieldInfoPtr_registeredIdentifier;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr_tutorialEffects;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_get_Identifier_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_RunAction_Public_Abstract_Virtual_New_IEnumerator_MutableAttributes_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_GetPersistentTutorialEffect_Public_Abstract_Virtual_New_Command_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRegistration_Protected_Void_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_IsRegistered_Protected_Boolean_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
