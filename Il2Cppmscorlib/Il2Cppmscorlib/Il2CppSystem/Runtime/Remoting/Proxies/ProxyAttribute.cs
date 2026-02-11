using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Activation;
using Il2CppSystem.Runtime.Remoting.Contexts;

namespace Il2CppSystem.Runtime.Remoting.Proxies
{
	// Token: 0x020002AE RID: 686
	public class ProxyAttribute : Attribute
	{
		// Token: 0x06002BD8 RID: 11224 RVA: 0x000E6F14 File Offset: 0x000E5114
		// Note: this type is marked as 'beforefieldinit'.
		static ProxyAttribute()
		{
			Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Proxies", "ProxyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr);
			ProxyAttribute.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100670385);
			ProxyAttribute.NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100670386);
			ProxyAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100670387);
			ProxyAttribute.NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProxyAttribute>.NativeClassPtr, 100670388);
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000E6F94 File Offset: 0x000E5194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379696, XrefRangeEnd = 1379706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MarshalByRefObject CreateInstance(Type serverType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serverType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProxyAttribute.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MarshalByRefObject>(intPtr3) : null;
			}
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000E6FF0 File Offset: 0x000E51F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1379706, XrefRangeEnd = 1379711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, Object serverObject, Context serverContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objRef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverObject);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProxyAttribute.NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RealProxy>(intPtr3) : null;
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000E7084 File Offset: 0x000E5284
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetPropertiesForNewContext(IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyAttribute.NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000E70C8 File Offset: 0x000E52C8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsContextOK(Context ctx, IConstructionCallMessage msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ctx);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProxyAttribute.NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BDD RID: 11229 RVA: 0x0000E9FD File Offset: 0x0000CBFD
		public ProxyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_MarshalByRefObject_Type_0;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeMethodInfoPtr_CreateProxy_Public_Virtual_New_RealProxy_ObjRef_Type_Object_Context_0;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertiesForNewContext_Public_Virtual_Final_New_Void_IConstructionCallMessage_0;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeMethodInfoPtr_IsContextOK_Public_Virtual_Final_New_Boolean_Context_IConstructionCallMessage_0;
	}
}
