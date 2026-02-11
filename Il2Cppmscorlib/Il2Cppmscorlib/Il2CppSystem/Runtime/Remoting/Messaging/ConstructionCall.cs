using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Proxies;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002F3 RID: 755
	[Serializable]
	public class ConstructionCall : MethodCall
	{
		// Token: 0x06002EB9 RID: 11961 RVA: 0x000F0F34 File Offset: 0x000EF134
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionCall()
		{
			Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionCall");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr);
			ConstructionCall.NativeFieldInfoPtr__activator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activator");
			ConstructionCall.NativeFieldInfoPtr__activationAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationAttributes");
			ConstructionCall.NativeFieldInfoPtr__contextProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_contextProperties");
			ConstructionCall.NativeFieldInfoPtr__activationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationType");
			ConstructionCall.NativeFieldInfoPtr__activationTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_activationTypeName");
			ConstructionCall.NativeFieldInfoPtr__isContextOk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_isContextOk");
			ConstructionCall.NativeFieldInfoPtr__sourceProxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, "_sourceProxy");
			ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670723);
			ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670724);
			ConstructionCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670725);
			ConstructionCall.NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670726);
			ConstructionCall.NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670727);
			ConstructionCall.NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670728);
			ConstructionCall.NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670729);
			ConstructionCall.NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670730);
			ConstructionCall.NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670731);
			ConstructionCall.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670732);
			ConstructionCall.NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670733);
			ConstructionCall.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670734);
			ConstructionCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670735);
			ConstructionCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670736);
			ConstructionCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670737);
			ConstructionCall.NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670738);
			ConstructionCall.NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr, 100670739);
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x000F1144 File Offset: 0x000EF344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1383015, RefRangeEnd = 1383016, XrefRangeStart = 1383012, XrefRangeEnd = 1383015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCall(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x000F1190 File Offset: 0x000EF390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383016, XrefRangeEnd = 1383021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCall(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCall>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x000F11F4 File Offset: 0x000EF3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383021, XrefRangeEnd = 1383034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002EBD RID: 11965 RVA: 0x000F1230 File Offset: 0x000EF430
		// (set) Token: 0x06002EBE RID: 11966 RVA: 0x000F126C File Offset: 0x000EF46C
		public unsafe bool IsContextOk
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002EBF RID: 11967 RVA: 0x000F12AC File Offset: 0x000EF4AC
		public unsafe virtual Type ActivationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383034, XrefRangeEnd = 1383046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000F12EC File Offset: 0x000EF4EC
		public unsafe virtual string ActivationTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06002EC1 RID: 11969 RVA: 0x000F1324 File Offset: 0x000EF524
		// (set) Token: 0x06002EC2 RID: 11970 RVA: 0x000F1364 File Offset: 0x000EF564
		public unsafe virtual IActivator Activator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002EC3 RID: 11971 RVA: 0x000F13A8 File Offset: 0x000EF5A8
		public unsafe virtual Il2CppReferenceArray<Object> CallSiteActivationAttributes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x000F13E8 File Offset: 0x000EF5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActivationAttributes(Il2CppReferenceArray<Object> attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002EC5 RID: 11973 RVA: 0x000F142C File Offset: 0x000EF62C
		public unsafe virtual IList ContextProperties
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383046, XrefRangeEnd = 1383051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000F146C File Offset: 0x000EF66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383051, XrefRangeEnd = 1383108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x000F14CC File Offset: 0x000EF6CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1383108, XrefRangeEnd = 1383128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002EC8 RID: 11976 RVA: 0x000F1530 File Offset: 0x000EF730
		public unsafe override IDictionary Properties
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCall.NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002EC9 RID: 11977 RVA: 0x000F157C File Offset: 0x000EF77C
		// (set) Token: 0x06002ECA RID: 11978 RVA: 0x000F15BC File Offset: 0x000EF7BC
		public unsafe RemotingProxy SourceProxy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RemotingProxy>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCall.NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x0000FE47 File Offset: 0x0000E047
		public ConstructionCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000F1600 File Offset: 0x000EF800
		// (set) Token: 0x06002ECD RID: 11981 RVA: 0x0000FE50 File Offset: 0x0000E050
		public unsafe IActivator _activator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000F1630 File Offset: 0x000EF830
		// (set) Token: 0x06002ECF RID: 11983 RVA: 0x0000FE6F File Offset: 0x0000E06F
		public unsafe Il2CppReferenceArray<Object> _activationAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x000F1660 File Offset: 0x000EF860
		// (set) Token: 0x06002ED1 RID: 11985 RVA: 0x0000FE8E File Offset: 0x0000E08E
		public unsafe IList _contextProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__contextProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__contextProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002ED2 RID: 11986 RVA: 0x000F1690 File Offset: 0x000EF890
		// (set) Token: 0x06002ED3 RID: 11987 RVA: 0x0000FEAD File Offset: 0x0000E0AD
		public unsafe Type _activationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x000F16C0 File Offset: 0x000EF8C0
		// (set) Token: 0x06002ED5 RID: 11989 RVA: 0x0000FECC File Offset: 0x0000E0CC
		public unsafe string _activationTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__activationTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002ED6 RID: 11990 RVA: 0x000F16E8 File Offset: 0x000EF8E8
		// (set) Token: 0x06002ED7 RID: 11991 RVA: 0x0000FEEB File Offset: 0x0000E0EB
		public unsafe bool _isContextOk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__isContextOk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__isContextOk)) = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x000F1710 File Offset: 0x000EF910
		// (set) Token: 0x06002ED9 RID: 11993 RVA: 0x0000FF06 File Offset: 0x0000E106
		public unsafe RemotingProxy _sourceProxy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__sourceProxy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RemotingProxy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructionCall.NativeFieldInfoPtr__sourceProxy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026E4 RID: 9956
		private static readonly IntPtr NativeFieldInfoPtr__activator;

		// Token: 0x040026E5 RID: 9957
		private static readonly IntPtr NativeFieldInfoPtr__activationAttributes;

		// Token: 0x040026E6 RID: 9958
		private static readonly IntPtr NativeFieldInfoPtr__contextProperties;

		// Token: 0x040026E7 RID: 9959
		private static readonly IntPtr NativeFieldInfoPtr__activationType;

		// Token: 0x040026E8 RID: 9960
		private static readonly IntPtr NativeFieldInfoPtr__activationTypeName;

		// Token: 0x040026E9 RID: 9961
		private static readonly IntPtr NativeFieldInfoPtr__isContextOk;

		// Token: 0x040026EA RID: 9962
		private static readonly IntPtr NativeFieldInfoPtr__sourceProxy;

		// Token: 0x040026EB RID: 9963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_0;

		// Token: 0x040026EC RID: 9964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040026ED RID: 9965
		private static readonly IntPtr NativeMethodInfoPtr_InitDictionary_Internal_Virtual_Void_0;

		// Token: 0x040026EE RID: 9966
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContextOk_Internal_get_Boolean_0;

		// Token: 0x040026EF RID: 9967
		private static readonly IntPtr NativeMethodInfoPtr_set_IsContextOk_Internal_set_Void_Boolean_0;

		// Token: 0x040026F0 RID: 9968
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x040026F1 RID: 9969
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationTypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040026F2 RID: 9970
		private static readonly IntPtr NativeMethodInfoPtr_get_Activator_Public_Virtual_Final_New_get_IActivator_0;

		// Token: 0x040026F3 RID: 9971
		private static readonly IntPtr NativeMethodInfoPtr_set_Activator_Public_Virtual_Final_New_set_Void_IActivator_0;

		// Token: 0x040026F4 RID: 9972
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteActivationAttributes_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040026F5 RID: 9973
		private static readonly IntPtr NativeMethodInfoPtr_SetActivationAttributes_Internal_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040026F6 RID: 9974
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextProperties_Public_Virtual_Final_New_get_IList_0;

		// Token: 0x040026F7 RID: 9975
		private static readonly IntPtr NativeMethodInfoPtr_InitMethodProperty_Internal_Virtual_Void_String_Object_0;

		// Token: 0x040026F8 RID: 9976
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040026F9 RID: 9977
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_Virtual_get_IDictionary_0;

		// Token: 0x040026FA RID: 9978
		private static readonly IntPtr NativeMethodInfoPtr_get_SourceProxy_Internal_get_RemotingProxy_0;

		// Token: 0x040026FB RID: 9979
		private static readonly IntPtr NativeMethodInfoPtr_set_SourceProxy_Internal_set_Void_RemotingProxy_0;
	}
}
