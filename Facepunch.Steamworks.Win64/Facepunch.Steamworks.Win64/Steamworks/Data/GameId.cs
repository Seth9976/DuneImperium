using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001FC RID: 508
	[StructLayout(2)]
	public struct GameId
	{
		// Token: 0x0600196B RID: 6507 RVA: 0x0007B294 File Offset: 0x00079494
		// Note: this type is marked as 'beforefieldinit'.
		static GameId()
		{
			Il2CppClassPointerStore<GameId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "GameId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameId>.NativeClassPtr);
			GameId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameId>.NativeClassPtr, "Value");
			GameId.NativeMethodInfoPtr_op_Implicit_Public_Static_GameId_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameId>.NativeClassPtr, 100667927);
			GameId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_GameId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameId>.NativeClassPtr, 100667928);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0007B300 File Offset: 0x00079500
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator GameId(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameId.NativeMethodInfoPtr_op_Implicit_Public_Static_GameId_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x0007B340 File Offset: 0x00079540
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(GameId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_GameId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00008417 File Offset: 0x00006617
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameId>.NativeClassPtr, ref this));
		}

		// Token: 0x04001EA3 RID: 7843
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001EA4 RID: 7844
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_GameId_UInt64_0;

		// Token: 0x04001EA5 RID: 7845
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_GameId_0;

		// Token: 0x04001EA6 RID: 7846
		[FieldOffset(0)]
		public ulong Value;
	}
}
