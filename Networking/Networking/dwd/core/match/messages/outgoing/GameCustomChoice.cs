using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.match.messages.outgoing
{
	// Token: 0x0200000C RID: 12
	public class GameCustomChoice : GameMessage
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000070FC File Offset: 0x000052FC
		// Note: this type is marked as 'beforefieldinit'.
		static GameCustomChoice()
		{
			Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "dwd.core.match.messages.outgoing", "GameCustomChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr);
			GameCustomChoice.NativeFieldInfoPtr_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr, "Selection");
			GameCustomChoice.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr, "Counter");
			GameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr, 100663320);
			GameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_GameID_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr, 100663321);
			GameCustomChoice.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr, 100663322);
			GameCustomChoice.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr, 100663323);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000071A4 File Offset: 0x000053A4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameCustomChoice()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000071E0 File Offset: 0x000053E0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1193497, RefRangeEnd = 1193503, XrefRangeStart = 1193495, XrefRangeEnd = 1193497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameCustomChoice(GameID gameID, int selection, int counter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameCustomChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selection;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCustomChoice.NativeMethodInfoPtr__ctor_Public_Void_GameID_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00007248 File Offset: 0x00005448
		[CallerCount(0)]
		public unsafe virtual int GetCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameCustomChoice.NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007284 File Offset: 0x00005484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193503, XrefRangeEnd = 1193511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameCustomChoice.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000023BF File Offset: 0x000005BF
		public GameCustomChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000072C8 File Offset: 0x000054C8
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000023C8 File Offset: 0x000005C8
		public unsafe int Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameCustomChoice.NativeFieldInfoPtr_Selection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameCustomChoice.NativeFieldInfoPtr_Selection)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000064 RID: 100 RVA: 0x000072F0 File Offset: 0x000054F0
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000023E3 File Offset: 0x000005E3
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameCustomChoice.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameCustomChoice.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr_Selection;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr_Counter;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_Int32_Int32_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_GetCounter_Public_Virtual_Final_New_Int32_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
