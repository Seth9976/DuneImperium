using System;
using Canis;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000019 RID: 25
	public class ScenarioTurn : ScenarioActionGroup
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00005AE0 File Offset: 0x00003CE0
		// Note: this type is marked as 'beforefieldinit'.
		static ScenarioTurn()
		{
			Il2CppClassPointerStore<ScenarioTurn>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-cutscenes.dll", "lotus", "ScenarioTurn");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScenarioTurn>.NativeClassPtr);
			ScenarioTurn.NativeFieldInfoPtr_playerNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenarioTurn>.NativeClassPtr, "playerNum");
			ScenarioTurn.NativeFieldInfoPtr_turn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScenarioTurn>.NativeClassPtr, "turn");
			ScenarioTurn.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioTurn>.NativeClassPtr, 100663462);
			ScenarioTurn.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScenarioTurn>.NativeClassPtr, 100663463);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00005B60 File Offset: 0x00003D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258620, XrefRangeEnd = 1258625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GetAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScenarioTurn.NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005BBC File Offset: 0x00003DBC
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScenarioTurn()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScenarioTurn>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScenarioTurn.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002561 File Offset: 0x00000761
		public ScenarioTurn(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00005BF8 File Offset: 0x00003DF8
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000256A File Offset: 0x0000076A
		public unsafe int playerNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioTurn.NativeFieldInfoPtr_playerNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioTurn.NativeFieldInfoPtr_playerNum)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00005C20 File Offset: 0x00003E20
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00002585 File Offset: 0x00000785
		public unsafe int turn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioTurn.NativeFieldInfoPtr_turn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScenarioTurn.NativeFieldInfoPtr_turn)) = value;
			}
		}

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_playerNum;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_turn;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_GetAction_Public_Virtual_Action_Match_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
