using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	// Token: 0x02000042 RID: 66
	public class ResourceProviderBase : Object
	{
		// Token: 0x06000342 RID: 834 RVA: 0x00011770 File Offset: 0x0000F970
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceProviderBase()
		{
			Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceProviders", "ResourceProviderBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr);
			ResourceProviderBase.NativeFieldInfoPtr_m_ProviderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, "m_ProviderId");
			ResourceProviderBase.NativeFieldInfoPtr_m_BehaviourFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, "m_BehaviourFlags");
			ResourceProviderBase.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663830);
			ResourceProviderBase.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663831);
			ResourceProviderBase.NativeMethodInfoPtr_CanProvide_Public_Virtual_New_Boolean_Type_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663832);
			ResourceProviderBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663833);
			ResourceProviderBase.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_IResourceLocation_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663834);
			ResourceProviderBase.NativeMethodInfoPtr_GetDefaultType_Public_Virtual_New_Type_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663835);
			ResourceProviderBase.NativeMethodInfoPtr_Provide_Public_Abstract_Virtual_New_Void_ProvideHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663836);
			ResourceProviderBase.NativeMethodInfoPtr_InitializeAsync_Public_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663837);
			ResourceProviderBase.NativeMethodInfoPtr_UnityEngine_ResourceManagement_ResourceProviders_IResourceProvider_get_BehaviourFlags_Private_Virtual_Final_New_get_ProviderBehaviourFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663838);
			ResourceProviderBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, 100663839);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00011890 File Offset: 0x0000FA90
		public unsafe virtual string ProviderId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140856, XrefRangeEnd = 1140859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x000118D4 File Offset: 0x0000FAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140859, XrefRangeEnd = 1140861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Initialize(string id, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Boolean_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00011940 File Offset: 0x0000FB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140861, XrefRangeEnd = 1140862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanProvide(Type t, IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_CanProvide_Public_Virtual_New_Boolean_Type_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000119AC File Offset: 0x0000FBAC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1011778, RefRangeEnd = 1011786, XrefRangeStart = 1011778, XrefRangeEnd = 1011786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000119F0 File Offset: 0x0000FBF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release(IResourceLocation location, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_Release_Public_Virtual_New_Void_IResourceLocation_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00011A50 File Offset: 0x0000FC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140862, XrefRangeEnd = 1140868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Type GetDefaultType(IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_GetDefaultType_Public_Virtual_New_Type_IResourceLocation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00011AAC File Offset: 0x0000FCAC
		[CallerCount(0)]
		public unsafe virtual void Provide(ProvideHandle provideHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(provideHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_Provide_Public_Abstract_Virtual_New_Void_ProvideHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00011B00 File Offset: 0x0000FD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140868, XrefRangeEnd = 1140891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<bool> InitializeAsync(ResourceManager rm, string id, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.NativeMethodInfoPtr_InitializeAsync_Public_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<bool>(intPtr);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00011B78 File Offset: 0x0000FD78
		public unsafe virtual ProviderBehaviourFlags UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider.BehaviourFlags
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceProviderBase.NativeMethodInfoPtr_UnityEngine_ResourceManagement_ResourceProviders_IResourceProvider_get_BehaviourFlags_Private_Virtual_Final_New_get_ProviderBehaviourFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00011BB4 File Offset: 0x0000FDB4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceProviderBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceProviderBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00003504 File Offset: 0x00001704
		public ResourceProviderBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00011BF0 File Offset: 0x0000FDF0
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000350D File Offset: 0x0000170D
		public unsafe string m_ProviderId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.NativeFieldInfoPtr_m_ProviderId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.NativeFieldInfoPtr_m_ProviderId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00011C18 File Offset: 0x0000FE18
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0000352C File Offset: 0x0000172C
		public unsafe ProviderBehaviourFlags m_BehaviourFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.NativeFieldInfoPtr_m_BehaviourFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.NativeFieldInfoPtr_m_BehaviourFlags)) = value;
			}
		}

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_m_ProviderId;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_m_BehaviourFlags;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderId_Public_Virtual_New_get_String_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Boolean_String_String_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_CanProvide_Public_Virtual_New_Boolean_Type_IResourceLocation_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_New_Void_IResourceLocation_Object_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultType_Public_Virtual_New_Type_IResourceLocation_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_Provide_Public_Abstract_Virtual_New_Void_ProvideHandle_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAsync_Public_Virtual_New_AsyncOperationHandle_1_Boolean_ResourceManager_String_String_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_ResourceProviders_IResourceProvider_get_BehaviourFlags_Private_Virtual_Final_New_get_ProviderBehaviourFlags_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000087 RID: 135
		public class BaseInitAsyncOp : AsyncOperationBase<bool>
		{
			// Token: 0x06000684 RID: 1668 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
			// Note: this type is marked as 'beforefieldinit'.
			static BaseInitAsyncOp()
			{
				Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, "BaseInitAsyncOp");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr);
				ResourceProviderBase.BaseInitAsyncOp.NativeFieldInfoPtr_m_CallBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr, "m_CallBack");
				ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr_Init_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr, 100663840);
				ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr, 100663841);
				ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr, 100663842);
				ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr, 100663843);
			}

			// Token: 0x06000685 RID: 1669 RVA: 0x0001ED80 File Offset: 0x0001CF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(Func<bool> callback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr_Init_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x0001EDC4 File Offset: 0x0001CFC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140842, XrefRangeEnd = 1140847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x0001EE0C File Offset: 0x0001D00C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140847, XrefRangeEnd = 1140852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x0001EE48 File Offset: 0x0001D048
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140852, XrefRangeEnd = 1140855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseInitAsyncOp()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceProviderBase.BaseInitAsyncOp>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceProviderBase.BaseInitAsyncOp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x000047C3 File Offset: 0x000029C3
			public BaseInitAsyncOp(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001F0 RID: 496
			// (get) Token: 0x0600068A RID: 1674 RVA: 0x0001EE84 File Offset: 0x0001D084
			// (set) Token: 0x0600068B RID: 1675 RVA: 0x000047CC File Offset: 0x000029CC
			public unsafe Func<bool> m_CallBack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.BaseInitAsyncOp.NativeFieldInfoPtr_m_CallBack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.BaseInitAsyncOp.NativeFieldInfoPtr_m_CallBack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004A4 RID: 1188
			private static readonly IntPtr NativeFieldInfoPtr_m_CallBack;

			// Token: 0x040004A5 RID: 1189
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Func_1_Boolean_0;

			// Token: 0x040004A6 RID: 1190
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x040004A7 RID: 1191
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x040004A8 RID: 1192
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000088 RID: 136
		[ObfuscatedName("UnityEngine.ResourceManagement.ResourceProviders.ResourceProviderBase+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600068C RID: 1676 RVA: 0x0001EEB4 File Offset: 0x0001D0B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ResourceProviderBase>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr);
				ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr, "id");
				ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr, "data");
				ResourceProviderBase.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr, 100663844);
				ResourceProviderBase.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializeAsync_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr, 100663845);
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x0001EF44 File Offset: 0x0001D144
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceProviderBase.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceProviderBase.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600068E RID: 1678 RVA: 0x0001EF80 File Offset: 0x0001D180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1140855, XrefRangeEnd = 1140856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceProviderBase.__c__DisplayClass10_0.NativeMethodInfoPtr__InitializeAsync_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x000047EB File Offset: 0x000029EB
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x06000690 RID: 1680 RVA: 0x0001EFBC File Offset: 0x0001D1BC
			// (set) Token: 0x06000691 RID: 1681 RVA: 0x000047F4 File Offset: 0x000029F4
			public unsafe ResourceProviderBase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceProviderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x06000692 RID: 1682 RVA: 0x0001EFEC File Offset: 0x0001D1EC
			// (set) Token: 0x06000693 RID: 1683 RVA: 0x00004813 File Offset: 0x00002A13
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170001F3 RID: 499
			// (get) Token: 0x06000694 RID: 1684 RVA: 0x0001F014 File Offset: 0x0001D214
			// (set) Token: 0x06000695 RID: 1685 RVA: 0x00004832 File Offset: 0x00002A32
			public unsafe string data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr_data);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceProviderBase.__c__DisplayClass10_0.NativeFieldInfoPtr_data), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040004A9 RID: 1193
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040004AA RID: 1194
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040004AB RID: 1195
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040004AC RID: 1196
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004AD RID: 1197
			private static readonly IntPtr NativeMethodInfoPtr__InitializeAsync_b__0_Internal_Boolean_0;
		}
	}
}
