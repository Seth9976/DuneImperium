using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x0200019A RID: 410
	public class ReceiveState : Object
	{
		// Token: 0x06001938 RID: 6456 RVA: 0x0007F48C File Offset: 0x0007D68C
		// Note: this type is marked as 'beforefieldinit'.
		static ReceiveState()
		{
			Il2CppClassPointerStore<ReceiveState>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ReceiveState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceiveState>.NativeClassPtr);
			ReceiveState.NativeFieldInfoPtr_Resp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveState>.NativeClassPtr, "Resp");
			ReceiveState.NativeFieldInfoPtr_ValidThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveState>.NativeClassPtr, "ValidThrough");
			ReceiveState.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveState>.NativeClassPtr, "Buffer");
			ReceiveState.NativeFieldInfoPtr_Connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceiveState>.NativeClassPtr, "Connection");
			ReceiveState.NativeMethodInfoPtr__ctor_Internal_Void_CommandStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceiveState>.NativeClassPtr, 100667265);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0007F520 File Offset: 0x0007D720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 471856, XrefRangeEnd = 471872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReceiveState(CommandStream connection)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceiveState>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceiveState.NativeMethodInfoPtr__ctor_Internal_Void_CommandStream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x0000AC7B File Offset: 0x00008E7B
		public ReceiveState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0007F56C File Offset: 0x0007D76C
		// (set) Token: 0x0600193C RID: 6460 RVA: 0x0000AC84 File Offset: 0x00008E84
		public unsafe ResponseDescription Resp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_Resp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResponseDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_Resp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x0007F59C File Offset: 0x0007D79C
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x0000ACA3 File Offset: 0x00008EA3
		public unsafe int ValidThrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_ValidThrough);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_ValidThrough)) = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0007F5C4 File Offset: 0x0007D7C4
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x0000ACBE File Offset: 0x00008EBE
		public unsafe Il2CppStructArray<byte> Buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_Buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0007F5F4 File Offset: 0x0007D7F4
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x0000ACDD File Offset: 0x00008EDD
		public unsafe CommandStream Connection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_Connection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandStream>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceiveState.NativeFieldInfoPtr_Connection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeFieldInfoPtr_Resp;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeFieldInfoPtr_ValidThrough;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeFieldInfoPtr_Buffer;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeFieldInfoPtr_Connection;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CommandStream_0;
	}
}
