using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020002D6 RID: 726
	public class AppDomainLevelActivator : Object
	{
		// Token: 0x06002D67 RID: 11623 RVA: 0x000EC7EC File Offset: 0x000EA9EC
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainLevelActivator()
		{
			Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "AppDomainLevelActivator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr);
			AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, "_activationUrl");
			AppDomainLevelActivator.NativeFieldInfoPtr__next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, "_next");
			AppDomainLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100670585);
			AppDomainLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100670586);
			AppDomainLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr, 100670587);
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x000EC880 File Offset: 0x000EAA80
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296744, XrefRangeEnd = 296798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainLevelActivator(string activationUrl, IActivator next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainLevelActivator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000EC8E0 File Offset: 0x000EAAE0
		public unsafe virtual IActivator NextActivator
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x000EC920 File Offset: 0x000EAB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382008, XrefRangeEnd = 1382042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainLevelActivator.NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConstructionReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x0000F440 File Offset: 0x0000D640
		public AppDomainLevelActivator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x000EC970 File Offset: 0x000EAB70
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x0000F449 File Offset: 0x0000D649
		public unsafe string _activationUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__activationUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000EC998 File Offset: 0x000EAB98
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x0000F468 File Offset: 0x0000D668
		public unsafe IActivator _next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainLevelActivator.NativeFieldInfoPtr__next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002612 RID: 9746
		private static readonly IntPtr NativeFieldInfoPtr__activationUrl;

		// Token: 0x04002613 RID: 9747
		private static readonly IntPtr NativeFieldInfoPtr__next;

		// Token: 0x04002614 RID: 9748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IActivator_0;

		// Token: 0x04002615 RID: 9749
		private static readonly IntPtr NativeMethodInfoPtr_get_NextActivator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x04002616 RID: 9750
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Final_New_IConstructionReturnMessage_IConstructionCallMessage_0;
	}
}
