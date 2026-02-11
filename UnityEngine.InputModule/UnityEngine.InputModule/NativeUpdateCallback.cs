using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal.Input
{
	// Token: 0x02000002 RID: 2
	public sealed class NativeUpdateCallback : MulticastDelegate
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000216C File Offset: 0x0000036C
		// Note: this type is marked as 'beforefieldinit'.
		static NativeUpdateCallback()
		{
			Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeUpdateCallback");
			NativeUpdateCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr, 100663297);
			NativeUpdateCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NativeInputUpdateType_ptr_NativeInputEventBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr, 100663298);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000021BC File Offset: 0x000003BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 474619, RefRangeEnd = 474622, XrefRangeStart = 474619, XrefRangeEnd = 474622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NativeUpdateCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeUpdateCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeUpdateCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002218 File Offset: 0x00000418
		[CallerCount(0)]
		public unsafe void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref updateType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = buffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeUpdateCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NativeInputUpdateType_ptr_NativeInputEventBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public NativeUpdateCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_NativeInputUpdateType_ptr_NativeInputEventBuffer_0;
	}
}
