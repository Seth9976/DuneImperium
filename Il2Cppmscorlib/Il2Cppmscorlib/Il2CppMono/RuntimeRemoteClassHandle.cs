using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono
{
	// Token: 0x0200000B RID: 11
	[StructLayout(2)]
	public struct RuntimeRemoteClassHandle
	{
		// Token: 0x06000033 RID: 51 RVA: 0x0002604C File Offset: 0x0002424C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeRemoteClassHandle()
		{
			Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeRemoteClassHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr);
			RuntimeRemoteClassHandle.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, "value");
			RuntimeRemoteClassHandle.NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, 100663392);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000260A4 File Offset: 0x000242A4
		public unsafe RuntimeClassHandle ProxyClass
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 426614, RefRangeEnd = 426617, XrefRangeStart = 426614, XrefRangeEnd = 426617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeRemoteClassHandle.NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000021B1 File Offset: 0x000003B1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RuntimeRemoteClassHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_ProxyClass_Internal_get_RuntimeClassHandle_0;

		// Token: 0x04000024 RID: 36
		[FieldOffset(0)]
		public IntPtr value;
	}
}
