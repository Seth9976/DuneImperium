using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Remoting.Proxies;

namespace Il2CppSystem.Runtime.Remoting.Activation
{
	// Token: 0x020002D5 RID: 725
	public class ActivationServices : Object
	{
		// Token: 0x06002D5B RID: 11611 RVA: 0x000EC498 File Offset: 0x000EA698
		// Note: this type is marked as 'beforefieldinit'.
		static ActivationServices()
		{
			Il2CppClassPointerStore<ActivationServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ActivationServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr);
			ActivationServices.NativeFieldInfoPtr__constructionActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, "_constructionActivator");
			ActivationServices.NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670577);
			ActivationServices.NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670578);
			ActivationServices.NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670579);
			ActivationServices.NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670580);
			ActivationServices.NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670581);
			ActivationServices.NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670582);
			ActivationServices.NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670583);
			ActivationServices.NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670584);
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000EC57C File Offset: 0x000EA77C
		public unsafe static IActivator ConstructionActivator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1381829, RefRangeEnd = 1381830, XrefRangeStart = 1381819, XrefRangeEnd = 1381829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
		}

		// Token: 0x06002D5D RID: 11613 RVA: 0x000EC5B0 File Offset: 0x000EA7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381855, RefRangeEnd = 1381856, XrefRangeStart = 1381830, XrefRangeEnd = 1381855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x000EC608 File Offset: 0x000EA808
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1381866, RefRangeEnd = 1381868, XrefRangeStart = 1381856, XrefRangeEnd = 1381866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002D5F RID: 11615 RVA: 0x000EC64C File Offset: 0x000EA84C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381954, RefRangeEnd = 1381955, XrefRangeStart = 1381868, XrefRangeEnd = 1381954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Il2CppReferenceArray<Object> activationAttributes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activationAttributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructionCall>(intPtr3) : null;
		}

		// Token: 0x06002D60 RID: 11616 RVA: 0x000EC6B4 File Offset: 0x000EA8B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1381994, RefRangeEnd = 1381995, XrefRangeStart = 1381955, XrefRangeEnd = 1381994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctorCall);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06002D61 RID: 11617 RVA: 0x000EC6F8 File Offset: 0x000EA8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381995, XrefRangeEnd = 1382004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateProxyForType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002D62 RID: 11618 RVA: 0x000EC73C File Offset: 0x000EA93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382004, XrefRangeEnd = 1382005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object AllocateUninitializedClassInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x000EC780 File Offset: 0x000EA980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382006, RefRangeEnd = 1382008, XrefRangeStart = 1382005, XrefRangeEnd = 1382006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableProxyActivation(Type type, bool enable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivationServices.NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x0000F425 File Offset: 0x0000D625
		public ActivationServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000EC7C4 File Offset: 0x000EA9C4
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x0000F42E File Offset: 0x0000D62E
		public unsafe static IActivator _constructionActivator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ActivationServices.NativeFieldInfoPtr__constructionActivator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActivationServices.NativeFieldInfoPtr__constructionActivator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002609 RID: 9737
		private static readonly IntPtr NativeFieldInfoPtr__constructionActivator;

		// Token: 0x0400260A RID: 9738
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0;

		// Token: 0x0400260B RID: 9739
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0;

		// Token: 0x0400260C RID: 9740
		private static readonly IntPtr NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0;

		// Token: 0x0400260D RID: 9741
		private static readonly IntPtr NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400260E RID: 9742
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0;

		// Token: 0x0400260F RID: 9743
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0;

		// Token: 0x04002610 RID: 9744
		private static readonly IntPtr NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0;

		// Token: 0x04002611 RID: 9745
		private static readonly IntPtr NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0;
	}
}
