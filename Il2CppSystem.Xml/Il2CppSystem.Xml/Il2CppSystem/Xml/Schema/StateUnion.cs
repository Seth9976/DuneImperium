using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000191 RID: 401
	[StructLayout(2)]
	public struct StateUnion
	{
		// Token: 0x06002214 RID: 8724 RVA: 0x000A3A50 File Offset: 0x000A1C50
		// Note: this type is marked as 'beforefieldinit'.
		static StateUnion()
		{
			Il2CppClassPointerStore<StateUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "StateUnion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateUnion>.NativeClassPtr);
			StateUnion.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "State");
			StateUnion.NativeFieldInfoPtr_AllElementsRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "AllElementsRequired");
			StateUnion.NativeFieldInfoPtr_CurPosIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "CurPosIndex");
			StateUnion.NativeFieldInfoPtr_NumberOfRunningPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, "NumberOfRunningPos");
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0000E6B6 File Offset: 0x0000C8B6
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StateUnion>.NativeClassPtr, ref this));
		}

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeFieldInfoPtr_AllElementsRequired;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeFieldInfoPtr_CurPosIndex;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeFieldInfoPtr_NumberOfRunningPos;

		// Token: 0x040019C9 RID: 6601
		[FieldOffset(0)]
		public int State;

		// Token: 0x040019CA RID: 6602
		[FieldOffset(0)]
		public int AllElementsRequired;

		// Token: 0x040019CB RID: 6603
		[FieldOffset(0)]
		public int CurPosIndex;

		// Token: 0x040019CC RID: 6604
		[FieldOffset(0)]
		public int NumberOfRunningPos;
	}
}
