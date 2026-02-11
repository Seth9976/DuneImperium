using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020002D8 RID: 728
	[Serializable]
	public class ContextLevelActivator : Object
	{
		// Token: 0x06002D75 RID: 11637 RVA: 0x000ECB00 File Offset: 0x000EAD00
		// Note: this type is marked as 'beforefieldinit'.
		static ContextLevelActivator()
		{
			Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ContextLevelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr);
			ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, "m_NextActivator");
			ContextLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100670591);
			ContextLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100670592);
			ContextLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr, 100670593);
		}

		// Token: 0x06002D76 RID: 11638 RVA: 0x000ECB80 File Offset: 0x000EAD80
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextLevelActivator(IActivator next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextLevelActivator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(next);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000ECBCC File Offset: 0x000EADCC
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000ECC0C File Offset: 0x000EAE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382049, XrefRangeEnd = 1382071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x0000F490 File Offset: 0x0000D690
		public ContextLevelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x000ECC5C File Offset: 0x000EAE5C
		// (set) Token: 0x06002D7B RID: 11643 RVA: 0x0000F499 File Offset: 0x0000D699
		public unsafe IActivator m_NextActivator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ContextLevelActivator.NativeFieldInfoPtr_m_NextActivator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400261A RID: 9754
		private static readonly IntPtr NativeFieldInfoPtr_m_NextActivator;

		// Token: 0x0400261B RID: 9755
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IActivator_0;

		// Token: 0x0400261C RID: 9756
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x0400261D RID: 9757
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
