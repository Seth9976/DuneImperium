using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A5 RID: 421
	public class EventWaitHandle : WaitHandle
	{
		// Token: 0x06001B60 RID: 7008 RVA: 0x000A4FEC File Offset: 0x000A31EC
		// Note: this type is marked as 'beforefieldinit'.
		static EventWaitHandle()
		{
			Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "EventWaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr);
			EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100668020);
			EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100668021);
			EventWaitHandle.NativeMethodInfoPtr_Reset_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100668022);
			EventWaitHandle.NativeMethodInfoPtr_Set_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr, 100668023);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x000A506C File Offset: 0x000A326C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353453, XrefRangeEnd = 1353454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWaitHandle(bool initialState, EventResetMode mode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x000A50C4 File Offset: 0x000A32C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353469, RefRangeEnd = 1353471, XrefRangeStart = 1353454, XrefRangeEnd = 1353469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventWaitHandle(bool initialState, EventResetMode mode, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventWaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialState;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x000A512C File Offset: 0x000A332C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1353473, RefRangeEnd = 1353477, XrefRangeStart = 1353471, XrefRangeEnd = 1353473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr_Reset_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x000A5168 File Offset: 0x000A3368
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 1353479, RefRangeEnd = 1353513, XrefRangeStart = 1353477, XrefRangeEnd = 1353479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Set()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventWaitHandle.NativeMethodInfoPtr_Set_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00008CCC File Offset: 0x00006ECC
		public EventWaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_0;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_EventResetMode_String_0;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Boolean_0;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Boolean_0;
	}
}
