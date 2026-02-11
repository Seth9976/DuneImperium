using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Metadata;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000298 RID: 664
	public class InternalRemotingServices : Object
	{
		// Token: 0x06002A62 RID: 10850 RVA: 0x000E1588 File Offset: 0x000DF788
		// Note: this type is marked as 'beforefieldinit'.
		static InternalRemotingServices()
		{
			Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "InternalRemotingServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr);
			InternalRemotingServices.NativeFieldInfoPtr__soapAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, "_soapAttributes");
			InternalRemotingServices.NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, 100670196);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000E15E0 File Offset: 0x000DF7E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1376914, RefRangeEnd = 1376919, XrefRangeStart = 1376852, XrefRangeEnd = 1376914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SoapAttribute GetCachedSoapAttribute(Object reflectionObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalRemotingServices.NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SoapAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x0000E18D File Offset: 0x0000C38D
		public InternalRemotingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000E1624 File Offset: 0x000DF824
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x0000E196 File Offset: 0x0000C396
		public unsafe static Hashtable _soapAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalRemotingServices.NativeFieldInfoPtr__soapAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalRemotingServices.NativeFieldInfoPtr__soapAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeFieldInfoPtr__soapAttributes;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0;
	}
}
