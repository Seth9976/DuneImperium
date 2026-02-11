using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001FF RID: 511
	[StructLayout(2)]
	public struct InventoryPurchaseResult
	{
		// Token: 0x0600197C RID: 6524 RVA: 0x0007B5AC File Offset: 0x000797AC
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryPurchaseResult()
		{
			Il2CppClassPointerStore<InventoryPurchaseResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "InventoryPurchaseResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryPurchaseResult>.NativeClassPtr);
			InventoryPurchaseResult.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryPurchaseResult>.NativeClassPtr, "Result");
			InventoryPurchaseResult.NativeFieldInfoPtr_OrderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryPurchaseResult>.NativeClassPtr, "OrderID");
			InventoryPurchaseResult.NativeFieldInfoPtr_TransID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryPurchaseResult>.NativeClassPtr, "TransID");
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x000084AB File Offset: 0x000066AB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryPurchaseResult>.NativeClassPtr, ref this));
		}

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeFieldInfoPtr_OrderID;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeFieldInfoPtr_TransID;

		// Token: 0x04001EB7 RID: 7863
		[FieldOffset(0)]
		public Result Result;

		// Token: 0x04001EB8 RID: 7864
		[FieldOffset(8)]
		public ulong OrderID;

		// Token: 0x04001EB9 RID: 7865
		[FieldOffset(16)]
		public ulong TransID;
	}
}
