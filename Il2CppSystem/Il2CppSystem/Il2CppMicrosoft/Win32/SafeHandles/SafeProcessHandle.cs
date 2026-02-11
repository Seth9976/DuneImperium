using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMicrosoft.Win32.SafeHandles
{
	// Token: 0x02000050 RID: 80
	public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		// Note: this type is marked as 'beforefieldinit'.
		static SafeProcessHandle()
		{
			Il2CppClassPointerStore<SafeProcessHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Microsoft.Win32.SafeHandles", "SafeProcessHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeProcessHandle>.NativeClassPtr);
			SafeProcessHandle.NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeProcessHandle>.NativeClassPtr, "InvalidHandle");
			SafeProcessHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeProcessHandle>.NativeClassPtr, 100664136);
			SafeProcessHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeProcessHandle>.NativeClassPtr, 100664137);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0002E130 File Offset: 0x0002C330
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433030, RefRangeEnd = 433032, XrefRangeStart = 433029, XrefRangeEnd = 433030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SafeProcessHandle(IntPtr existingHandle, bool ownsHandle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeProcessHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref existingHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownsHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeProcessHandle.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0002E188 File Offset: 0x0002C388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 433032, XrefRangeEnd = 433041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SafeProcessHandle.NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00003755 File Offset: 0x00001955
		public SafeProcessHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0002E1C4 File Offset: 0x0002C3C4
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0000375E File Offset: 0x0000195E
		public unsafe static SafeProcessHandle InvalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SafeProcessHandle.NativeFieldInfoPtr_InvalidHandle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeProcessHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SafeProcessHandle.NativeFieldInfoPtr_InvalidHandle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHandle;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Boolean_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;
	}
}
