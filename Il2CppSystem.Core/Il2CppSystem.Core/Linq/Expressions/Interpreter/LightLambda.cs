using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Dynamic.Utils;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Text;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D6 RID: 214
	public class LightLambda : Object
	{
		// Token: 0x06000D1B RID: 3355 RVA: 0x00045F18 File Offset: 0x00044118
		// Note: this type is marked as 'beforefieldinit'.
		static LightLambda()
		{
			Il2CppClassPointerStore<LightLambda>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LightLambda");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightLambda>.NativeClassPtr);
			LightLambda.NativeFieldInfoPtr__closure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, "_closure");
			LightLambda.NativeFieldInfoPtr__interpreter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, "_interpreter");
			LightLambda.NativeFieldInfoPtr__runCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, "_runCache");
			LightLambda.NativeFieldInfoPtr__delegateCreator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, "_delegateCreator");
			LightLambda.NativeMethodInfoPtr_Run0_Internal_TRet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665664);
			LightLambda.NativeMethodInfoPtr_RunVoid0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665665);
			LightLambda.NativeMethodInfoPtr_MakeRun0_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665666);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid0_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665667);
			LightLambda.NativeMethodInfoPtr_Run1_Internal_TRet_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665668);
			LightLambda.NativeMethodInfoPtr_RunVoid1_Internal_Void_T0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665669);
			LightLambda.NativeMethodInfoPtr_MakeRun1_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665670);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid1_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665671);
			LightLambda.NativeMethodInfoPtr_Run2_Internal_TRet_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665672);
			LightLambda.NativeMethodInfoPtr_RunVoid2_Internal_Void_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665673);
			LightLambda.NativeMethodInfoPtr_MakeRun2_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665674);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid2_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665675);
			LightLambda.NativeMethodInfoPtr_Run3_Internal_TRet_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665676);
			LightLambda.NativeMethodInfoPtr_RunVoid3_Internal_Void_T0_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665677);
			LightLambda.NativeMethodInfoPtr_MakeRun3_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665678);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid3_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665679);
			LightLambda.NativeMethodInfoPtr_Run4_Internal_TRet_T0_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665680);
			LightLambda.NativeMethodInfoPtr_RunVoid4_Internal_Void_T0_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665681);
			LightLambda.NativeMethodInfoPtr_MakeRun4_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665682);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid4_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665683);
			LightLambda.NativeMethodInfoPtr_Run5_Internal_TRet_T0_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665684);
			LightLambda.NativeMethodInfoPtr_RunVoid5_Internal_Void_T0_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665685);
			LightLambda.NativeMethodInfoPtr_MakeRun5_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665686);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid5_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665687);
			LightLambda.NativeMethodInfoPtr_Run6_Internal_TRet_T0_T1_T2_T3_T4_T5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665688);
			LightLambda.NativeMethodInfoPtr_RunVoid6_Internal_Void_T0_T1_T2_T3_T4_T5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665689);
			LightLambda.NativeMethodInfoPtr_MakeRun6_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665690);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid6_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665691);
			LightLambda.NativeMethodInfoPtr_Run7_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665692);
			LightLambda.NativeMethodInfoPtr_RunVoid7_Internal_Void_T0_T1_T2_T3_T4_T5_T6_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665693);
			LightLambda.NativeMethodInfoPtr_MakeRun7_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665694);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid7_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665695);
			LightLambda.NativeMethodInfoPtr_Run8_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665696);
			LightLambda.NativeMethodInfoPtr_RunVoid8_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665697);
			LightLambda.NativeMethodInfoPtr_MakeRun8_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665698);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid8_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665699);
			LightLambda.NativeMethodInfoPtr_Run9_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665700);
			LightLambda.NativeMethodInfoPtr_RunVoid9_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665701);
			LightLambda.NativeMethodInfoPtr_MakeRun9_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665702);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid9_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665703);
			LightLambda.NativeMethodInfoPtr_Run10_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665704);
			LightLambda.NativeMethodInfoPtr_RunVoid10_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665705);
			LightLambda.NativeMethodInfoPtr_MakeRun10_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665706);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid10_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665707);
			LightLambda.NativeMethodInfoPtr_Run11_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665708);
			LightLambda.NativeMethodInfoPtr_RunVoid11_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665709);
			LightLambda.NativeMethodInfoPtr_MakeRun11_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665710);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid11_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665711);
			LightLambda.NativeMethodInfoPtr_Run12_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665712);
			LightLambda.NativeMethodInfoPtr_RunVoid12_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665713);
			LightLambda.NativeMethodInfoPtr_MakeRun12_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665714);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid12_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665715);
			LightLambda.NativeMethodInfoPtr_Run13_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665716);
			LightLambda.NativeMethodInfoPtr_RunVoid13_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665717);
			LightLambda.NativeMethodInfoPtr_MakeRun13_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665718);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid13_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665719);
			LightLambda.NativeMethodInfoPtr_Run14_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665720);
			LightLambda.NativeMethodInfoPtr_RunVoid14_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665721);
			LightLambda.NativeMethodInfoPtr_MakeRun14_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665722);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid14_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665723);
			LightLambda.NativeMethodInfoPtr_Run15_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665724);
			LightLambda.NativeMethodInfoPtr_RunVoid15_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665725);
			LightLambda.NativeMethodInfoPtr_MakeRun15_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665726);
			LightLambda.NativeMethodInfoPtr_MakeRunVoid15_Internal_Static_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665727);
			LightLambda.NativeMethodInfoPtr__ctor_Internal_Void_LightDelegateCreator_Il2CppReferenceArray_1_IStrongBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665728);
			LightLambda.NativeMethodInfoPtr_get_DebugView_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665729);
			LightLambda.NativeMethodInfoPtr_GetRunDelegateCtor_Private_Static_Func_2_LightLambda_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665730);
			LightLambda.NativeMethodInfoPtr_MakeRunDelegateCtor_Private_Static_Func_2_LightLambda_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665731);
			LightLambda.NativeMethodInfoPtr_CreateCustomDelegate_Private_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665732);
			LightLambda.NativeMethodInfoPtr_MakeDelegate_Internal_Delegate_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665733);
			LightLambda.NativeMethodInfoPtr_MakeFrame_Private_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665734);
			LightLambda.NativeMethodInfoPtr_RunVoidRef2_Internal_Void_byref_T0_byref_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665735);
			LightLambda.NativeMethodInfoPtr_Run_Public_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665736);
			LightLambda.NativeMethodInfoPtr_RunVoid_Public_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, 100665737);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00046560 File Offset: 0x00044760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022656, XrefRangeEnd = 1022668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run0<TRet>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run0_Internal_TRet_0<TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr, false, true);
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x0004659C File Offset: 0x0004479C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022668, XrefRangeEnd = 1022677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_RunVoid0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000465D0 File Offset: 0x000447D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022677, XrefRangeEnd = 1022680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun0<TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun0_Internal_Static_Delegate_LightLambda_0<TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00046614 File Offset: 0x00044814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022680, XrefRangeEnd = 1022686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid0(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_MakeRunVoid0_Internal_Static_Delegate_LightLambda_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00046658 File Offset: 0x00044858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022686, XrefRangeEnd = 1022703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run1<T0, TRet>(T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run1_Internal_TRet_T0_0<T0, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<TRet>(intPtr2, false, true);
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000466D8 File Offset: 0x000448D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022703, XrefRangeEnd = 1022715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid1<T0>(T0 arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid1_Internal_Void_T0_0<T0>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00046750 File Offset: 0x00044950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun1<T0, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun1_Internal_Static_Delegate_LightLambda_0<T0, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00046794 File Offset: 0x00044994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid1<T0>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid1_Internal_Static_Delegate_LightLambda_0<T0>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x000467D8 File Offset: 0x000449D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022715, XrefRangeEnd = 1022737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run2_Internal_TRet_T0_T1_0<T0, T1, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr3, false, true);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x000468A0 File Offset: 0x00044AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022737, XrefRangeEnd = 1022754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid2<T0, T1>(T0 arg0, T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid2_Internal_Void_T0_T1_0<T0, T1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00046960 File Offset: 0x00044B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun2_Internal_Static_Delegate_LightLambda_0<T0, T1, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x000469A4 File Offset: 0x00044BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid2_Internal_Static_Delegate_LightLambda_0<T0, T1>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000469E8 File Offset: 0x00044BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022754, XrefRangeEnd = 1022781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run3_Internal_TRet_T0_T1_T2_0<T0, T1, T2, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr4, false, true);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00046AF8 File Offset: 0x00044CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022781, XrefRangeEnd = 1022803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid3_Internal_Void_T0_T1_T2_0<T0, T1, T2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00046C00 File Offset: 0x00044E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun3_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00046C44 File Offset: 0x00044E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid3_Internal_Static_Delegate_LightLambda_0<T0, T1, T2>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00046C88 File Offset: 0x00044E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022803, XrefRangeEnd = 1022835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run4_Internal_TRet_T0_T1_T2_T3_0<T0, T1, T2, T3, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr5, false, true);
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00046DE4 File Offset: 0x00044FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022835, XrefRangeEnd = 1022862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid4_Internal_Void_T0_T1_T2_T3_0<T0, T1, T2, T3>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00046F38 File Offset: 0x00045138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun4_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00046F7C File Offset: 0x0004517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid4_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00046FC0 File Offset: 0x000451C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022862, XrefRangeEnd = 1022899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run5_Internal_TRet_T0_T1_T2_T3_T4_0<T0, T1, T2, T3, T4, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr6, false, true);
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00047164 File Offset: 0x00045364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022899, XrefRangeEnd = 1022931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid5_Internal_Void_T0_T1_T2_T3_T4_0<T0, T1, T2, T3, T4>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00047300 File Offset: 0x00045500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun5_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00047344 File Offset: 0x00045544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid5_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00047388 File Offset: 0x00045588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022931, XrefRangeEnd = 1022973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			IntPtr intPtr8;
			IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run6_Internal_TRet_T0_T1_T2_T3_T4_T5_0<T0, T1, T2, T3, T4, T5, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr8);
			Il2CppException.RaiseExceptionIfNecessary(intPtr8);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr7, false, true);
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00047574 File Offset: 0x00045774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022973, XrefRangeEnd = 1023010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			IntPtr intPtr8;
			IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid6_Internal_Void_T0_T1_T2_T3_T4_T5_0<T0, T1, T2, T3, T4, T5>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr8);
			Il2CppException.RaiseExceptionIfNecessary(intPtr8);
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00047758 File Offset: 0x00045958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun6_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0004779C File Offset: 0x0004599C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid6_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000477E0 File Offset: 0x000459E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023010, XrefRangeEnd = 1023057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			IntPtr intPtr9;
			IntPtr intPtr8 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run7_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_0<T0, T1, T2, T3, T4, T5, T6, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr9);
			Il2CppException.RaiseExceptionIfNecessary(intPtr9);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr8, false, true);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00047A14 File Offset: 0x00045C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023057, XrefRangeEnd = 1023099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			IntPtr intPtr9;
			IntPtr intPtr8 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid7_Internal_Void_T0_T1_T2_T3_T4_T5_T6_0<T0, T1, T2, T3, T4, T5, T6>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr9);
			Il2CppException.RaiseExceptionIfNecessary(intPtr9);
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00047C40 File Offset: 0x00045E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun7_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00047C84 File Offset: 0x00045E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid7_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00047CC8 File Offset: 0x00045EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023099, XrefRangeEnd = 1023151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			IntPtr intPtr10;
			IntPtr intPtr9 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run8_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_0<T0, T1, T2, T3, T4, T5, T6, T7, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr10);
			Il2CppException.RaiseExceptionIfNecessary(intPtr10);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr9, false, true);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00047F48 File Offset: 0x00046148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023151, XrefRangeEnd = 1023198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			IntPtr intPtr10;
			IntPtr intPtr9 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid8_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_0<T0, T1, T2, T3, T4, T5, T6, T7>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr10);
			Il2CppException.RaiseExceptionIfNecessary(intPtr10);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x000481C0 File Offset: 0x000463C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun8_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00048204 File Offset: 0x00046404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid8_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00048248 File Offset: 0x00046448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023198, XrefRangeEnd = 1023255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			IntPtr intPtr11;
			IntPtr intPtr10 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run9_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr11);
			Il2CppException.RaiseExceptionIfNecessary(intPtr11);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr10, false, true);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00048510 File Offset: 0x00046710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023255, XrefRangeEnd = 1023307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			IntPtr intPtr11;
			IntPtr intPtr10 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid9_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_0<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr11);
			Il2CppException.RaiseExceptionIfNecessary(intPtr11);
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x000487D0 File Offset: 0x000469D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun9_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00048814 File Offset: 0x00046A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid9_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00048858 File Offset: 0x00046A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023307, XrefRangeEnd = 1023369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			IntPtr intPtr12;
			IntPtr intPtr11 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run10_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr12);
			Il2CppException.RaiseExceptionIfNecessary(intPtr12);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr11, false, true);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00048B6C File Offset: 0x00046D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023369, XrefRangeEnd = 1023426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			IntPtr intPtr12;
			IntPtr intPtr11 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid10_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr12);
			Il2CppException.RaiseExceptionIfNecessary(intPtr12);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00048E78 File Offset: 0x00047078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun10_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00048EBC File Offset: 0x000470BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid10_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00048F00 File Offset: 0x00047100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023426, XrefRangeEnd = 1023493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			IntPtr intPtr13;
			IntPtr intPtr12 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run11_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr13);
			Il2CppException.RaiseExceptionIfNecessary(intPtr13);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr12, false, true);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0004925C File Offset: 0x0004745C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023493, XrefRangeEnd = 1023555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			IntPtr intPtr13;
			IntPtr intPtr12 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid11_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr13);
			Il2CppException.RaiseExceptionIfNecessary(intPtr13);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000495B0 File Offset: 0x000477B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun11_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000495F4 File Offset: 0x000477F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid11_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00049638 File Offset: 0x00047838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023555, XrefRangeEnd = 1023627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			IntPtr intPtr14;
			IntPtr intPtr13 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run12_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr14);
			Il2CppException.RaiseExceptionIfNecessary(intPtr14);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr13, false, true);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000499E0 File Offset: 0x00047BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023627, XrefRangeEnd = 1023694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			IntPtr intPtr14;
			IntPtr intPtr13 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid12_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr14);
			Il2CppException.RaiseExceptionIfNecessary(intPtr14);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00049D80 File Offset: 0x00047F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun12_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00049DC4 File Offset: 0x00047FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid12_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00049E08 File Offset: 0x00048008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023694, XrefRangeEnd = 1023771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			ref IntPtr ptr14 = ref ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr13;
			if (!typeof(T12).IsValueType)
			{
				T12 t13 = arg12;
				intPtr13 = ((t13 is string) ? IL2CPP.ManagedStringToIl2Cpp(t13 as string) : IL2CPP.Il2CppObjectBaseToPtr(t13 as Il2CppObjectBase));
			}
			else
			{
				intPtr13 = ref arg12;
			}
			ptr14 = intPtr13;
			IntPtr intPtr15;
			IntPtr intPtr14 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run13_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr15);
			Il2CppException.RaiseExceptionIfNecessary(intPtr15);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr14, false, true);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0004A1F8 File Offset: 0x000483F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023771, XrefRangeEnd = 1023843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			ref IntPtr ptr14 = ref ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr13;
			if (!typeof(T12).IsValueType)
			{
				T12 t13 = arg12;
				intPtr13 = ((t13 is string) ? IL2CPP.ManagedStringToIl2Cpp(t13 as string) : IL2CPP.Il2CppObjectBaseToPtr(t13 as Il2CppObjectBase));
			}
			else
			{
				intPtr13 = ref arg12;
			}
			ptr14 = intPtr13;
			IntPtr intPtr15;
			IntPtr intPtr14 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid13_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr15);
			Il2CppException.RaiseExceptionIfNecessary(intPtr15);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0004A5E0 File Offset: 0x000487E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun13_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0004A624 File Offset: 0x00048824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid13_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0004A668 File Offset: 0x00048868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023843, XrefRangeEnd = 1023925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			ref IntPtr ptr14 = ref ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr13;
			if (!typeof(T12).IsValueType)
			{
				T12 t13 = arg12;
				intPtr13 = ((t13 is string) ? IL2CPP.ManagedStringToIl2Cpp(t13 as string) : IL2CPP.Il2CppObjectBaseToPtr(t13 as Il2CppObjectBase));
			}
			else
			{
				intPtr13 = ref arg12;
			}
			ptr14 = intPtr13;
			ref IntPtr ptr15 = ref ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr14;
			if (!typeof(T13).IsValueType)
			{
				T13 t14 = arg13;
				intPtr14 = ((t14 is string) ? IL2CPP.ManagedStringToIl2Cpp(t14 as string) : IL2CPP.Il2CppObjectBaseToPtr(t14 as Il2CppObjectBase));
			}
			else
			{
				intPtr14 = ref arg13;
			}
			ptr15 = intPtr14;
			IntPtr intPtr16;
			IntPtr intPtr15 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run14_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr16);
			Il2CppException.RaiseExceptionIfNecessary(intPtr16);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr15, false, true);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0004AAA4 File Offset: 0x00048CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023925, XrefRangeEnd = 1024002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			ref IntPtr ptr14 = ref ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr13;
			if (!typeof(T12).IsValueType)
			{
				T12 t13 = arg12;
				intPtr13 = ((t13 is string) ? IL2CPP.ManagedStringToIl2Cpp(t13 as string) : IL2CPP.Il2CppObjectBaseToPtr(t13 as Il2CppObjectBase));
			}
			else
			{
				intPtr13 = ref arg12;
			}
			ptr14 = intPtr13;
			ref IntPtr ptr15 = ref ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr14;
			if (!typeof(T13).IsValueType)
			{
				T13 t14 = arg13;
				intPtr14 = ((t14 is string) ? IL2CPP.ManagedStringToIl2Cpp(t14 as string) : IL2CPP.Il2CppObjectBaseToPtr(t14 as Il2CppObjectBase));
			}
			else
			{
				intPtr14 = ref arg13;
			}
			ptr15 = intPtr14;
			IntPtr intPtr16;
			IntPtr intPtr15 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid14_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr16);
			Il2CppException.RaiseExceptionIfNecessary(intPtr16);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0004AED8 File Offset: 0x000490D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun14_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0004AF1C File Offset: 0x0004911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid14_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0004AF60 File Offset: 0x00049160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024002, XrefRangeEnd = 1024089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			ref IntPtr ptr14 = ref ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr13;
			if (!typeof(T12).IsValueType)
			{
				T12 t13 = arg12;
				intPtr13 = ((t13 is string) ? IL2CPP.ManagedStringToIl2Cpp(t13 as string) : IL2CPP.Il2CppObjectBaseToPtr(t13 as Il2CppObjectBase));
			}
			else
			{
				intPtr13 = ref arg12;
			}
			ptr14 = intPtr13;
			ref IntPtr ptr15 = ref ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr14;
			if (!typeof(T13).IsValueType)
			{
				T13 t14 = arg13;
				intPtr14 = ((t14 is string) ? IL2CPP.ManagedStringToIl2Cpp(t14 as string) : IL2CPP.Il2CppObjectBaseToPtr(t14 as Il2CppObjectBase));
			}
			else
			{
				intPtr14 = ref arg13;
			}
			ptr15 = intPtr14;
			ref IntPtr ptr16 = ref ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr15;
			if (!typeof(T14).IsValueType)
			{
				T14 t15 = arg14;
				intPtr15 = ((t15 is string) ? IL2CPP.ManagedStringToIl2Cpp(t15 as string) : IL2CPP.Il2CppObjectBaseToPtr(t15 as Il2CppObjectBase));
			}
			else
			{
				intPtr15 = ref arg14;
			}
			ptr16 = intPtr15;
			IntPtr intPtr17;
			IntPtr intPtr16 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_Run15_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr17);
			Il2CppException.RaiseExceptionIfNecessary(intPtr17);
			return IL2CPP.PointerToValueGeneric<TRet>(intPtr16, false, true);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0004B3E4 File Offset: 0x000495E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024089, XrefRangeEnd = 1024171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T0).IsValueType)
				{
					T0 t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T6).IsValueType)
			{
				T6 t7 = arg6;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref arg6;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T7).IsValueType)
			{
				T7 t8 = arg7;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref arg7;
			}
			ptr9 = intPtr8;
			ref IntPtr ptr10 = ref ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr9;
			if (!typeof(T8).IsValueType)
			{
				T8 t9 = arg8;
				intPtr9 = ((t9 is string) ? IL2CPP.ManagedStringToIl2Cpp(t9 as string) : IL2CPP.Il2CppObjectBaseToPtr(t9 as Il2CppObjectBase));
			}
			else
			{
				intPtr9 = ref arg8;
			}
			ptr10 = intPtr9;
			ref IntPtr ptr11 = ref ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr10;
			if (!typeof(T9).IsValueType)
			{
				T9 t10 = arg9;
				intPtr10 = ((t10 is string) ? IL2CPP.ManagedStringToIl2Cpp(t10 as string) : IL2CPP.Il2CppObjectBaseToPtr(t10 as Il2CppObjectBase));
			}
			else
			{
				intPtr10 = ref arg9;
			}
			ptr11 = intPtr10;
			ref IntPtr ptr12 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr11;
			if (!typeof(T10).IsValueType)
			{
				T10 t11 = arg10;
				intPtr11 = ((t11 is string) ? IL2CPP.ManagedStringToIl2Cpp(t11 as string) : IL2CPP.Il2CppObjectBaseToPtr(t11 as Il2CppObjectBase));
			}
			else
			{
				intPtr11 = ref arg10;
			}
			ptr12 = intPtr11;
			ref IntPtr ptr13 = ref ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr12;
			if (!typeof(T11).IsValueType)
			{
				T11 t12 = arg11;
				intPtr12 = ((t12 is string) ? IL2CPP.ManagedStringToIl2Cpp(t12 as string) : IL2CPP.Il2CppObjectBaseToPtr(t12 as Il2CppObjectBase));
			}
			else
			{
				intPtr12 = ref arg11;
			}
			ptr13 = intPtr12;
			ref IntPtr ptr14 = ref ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr13;
			if (!typeof(T12).IsValueType)
			{
				T12 t13 = arg12;
				intPtr13 = ((t13 is string) ? IL2CPP.ManagedStringToIl2Cpp(t13 as string) : IL2CPP.Il2CppObjectBaseToPtr(t13 as Il2CppObjectBase));
			}
			else
			{
				intPtr13 = ref arg12;
			}
			ptr14 = intPtr13;
			ref IntPtr ptr15 = ref ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr14;
			if (!typeof(T13).IsValueType)
			{
				T13 t14 = arg13;
				intPtr14 = ((t14 is string) ? IL2CPP.ManagedStringToIl2Cpp(t14 as string) : IL2CPP.Il2CppObjectBaseToPtr(t14 as Il2CppObjectBase));
			}
			else
			{
				intPtr14 = ref arg13;
			}
			ptr15 = intPtr14;
			ref IntPtr ptr16 = ref ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr15;
			if (!typeof(T14).IsValueType)
			{
				T14 t15 = arg14;
				intPtr15 = ((t15 is string) ? IL2CPP.ManagedStringToIl2Cpp(t15 as string) : IL2CPP.Il2CppObjectBaseToPtr(t15 as Il2CppObjectBase));
			}
			else
			{
				intPtr15 = ref arg14;
			}
			ptr16 = intPtr15;
			IntPtr intPtr17;
			IntPtr intPtr16 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoid15_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr17);
			Il2CppException.RaiseExceptionIfNecessary(intPtr17);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0004B860 File Offset: 0x00049A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRun15_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0004B8A4 File Offset: 0x00049AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_MakeRunVoid15_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0004B8E8 File Offset: 0x00049AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024171, XrefRangeEnd = 1024176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightLambda(LightDelegateCreator delegateCreator, Il2CppReferenceArray<IStrongBox> closure)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightLambda>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateCreator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(closure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr__ctor_Internal_Void_LightDelegateCreator_Il2CppReferenceArray_1_IStrongBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0004B948 File Offset: 0x00049B48
		public unsafe string DebugView
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024176, XrefRangeEnd = 1024205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_get_DebugView_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0004B980 File Offset: 0x00049B80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1024224, RefRangeEnd = 1024226, XrefRangeStart = 1024205, XrefRangeEnd = 1024224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_GetRunDelegateCtor_Private_Static_Func_2_LightLambda_Delegate_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<LightLambda, Delegate>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0004B9C4 File Offset: 0x00049BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1024322, RefRangeEnd = 1024323, XrefRangeStart = 1024226, XrefRangeEnd = 1024322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_MakeRunDelegateCtor_Private_Static_Func_2_LightLambda_Delegate_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<LightLambda, Delegate>>(intPtr3) : null;
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0004BA08 File Offset: 0x00049C08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1024497, RefRangeEnd = 1024499, XrefRangeStart = 1024323, XrefRangeEnd = 1024497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Delegate CreateCustomDelegate(Type delegateType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_CreateCustomDelegate_Private_Delegate_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0004BA58 File Offset: 0x00049C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024499, XrefRangeEnd = 1024504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Delegate MakeDelegate(Type delegateType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_MakeDelegate_Internal_Delegate_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0004BAA8 File Offset: 0x00049CA8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1024508, RefRangeEnd = 1024540, XrefRangeStart = 1024504, XrefRangeEnd = 1024508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InterpretedFrame MakeFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_MakeFrame_Private_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InterpretedFrame>(intPtr3) : null;
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0004BAE8 File Offset: 0x00049CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024540, XrefRangeEnd = 1024557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LightLambda.MethodInfoStoreGeneric_RunVoidRef2_Internal_Void_byref_T0_byref_T1_0<T0, T1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arg0 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			arg1 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr6, false, false));
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0004BB6C File Offset: 0x00049D6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1024570, RefRangeEnd = 1024573, XrefRangeStart = 1024557, XrefRangeEnd = 1024570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Run([Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_Run_Public_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0004BBCC File Offset: 0x00049DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1024585, RefRangeEnd = 1024588, XrefRangeStart = 1024573, XrefRangeEnd = 1024585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object RunVoid([Optional] Il2CppReferenceArray<Object> arguments)
		{
			if (arguments == null)
			{
				arguments = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.NativeMethodInfoPtr_RunVoid_Public_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00006083 File Offset: 0x00004283
		public Object Run(params Object[] arguments)
		{
			return this.Run(new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00006091 File Offset: 0x00004291
		public Object RunVoid(params Object[] arguments)
		{
			return this.RunVoid(new Il2CppReferenceArray<Object>(arguments));
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0000609F File Offset: 0x0000429F
		public LightLambda(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x0004BC2C File Offset: 0x00049E2C
		// (set) Token: 0x06000D6A RID: 3434 RVA: 0x000060A8 File Offset: 0x000042A8
		public unsafe Il2CppReferenceArray<IStrongBox> _closure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.NativeFieldInfoPtr__closure);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IStrongBox>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.NativeFieldInfoPtr__closure), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0004BC5C File Offset: 0x00049E5C
		// (set) Token: 0x06000D6C RID: 3436 RVA: 0x000060C7 File Offset: 0x000042C7
		public unsafe Interpreter _interpreter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.NativeFieldInfoPtr__interpreter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpreter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.NativeFieldInfoPtr__interpreter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0004BC8C File Offset: 0x00049E8C
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x000060E6 File Offset: 0x000042E6
		public unsafe static CacheDict<Type, Func<LightLambda, Delegate>> _runCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightLambda.NativeFieldInfoPtr__runCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CacheDict<Type, Func<LightLambda, Delegate>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightLambda.NativeFieldInfoPtr__runCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0004BCB4 File Offset: 0x00049EB4
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x000060F8 File Offset: 0x000042F8
		public unsafe LightDelegateCreator _delegateCreator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.NativeFieldInfoPtr__delegateCreator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightDelegateCreator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.NativeFieldInfoPtr__delegateCreator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeFieldInfoPtr__closure;

		// Token: 0x040009A3 RID: 2467
		private static readonly IntPtr NativeFieldInfoPtr__interpreter;

		// Token: 0x040009A4 RID: 2468
		private static readonly IntPtr NativeFieldInfoPtr__runCache;

		// Token: 0x040009A5 RID: 2469
		private static readonly IntPtr NativeFieldInfoPtr__delegateCreator;

		// Token: 0x040009A6 RID: 2470
		private static readonly IntPtr NativeMethodInfoPtr_Run0_Internal_TRet_0;

		// Token: 0x040009A7 RID: 2471
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid0_Internal_Void_0;

		// Token: 0x040009A8 RID: 2472
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun0_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009A9 RID: 2473
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid0_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009AA RID: 2474
		private static readonly IntPtr NativeMethodInfoPtr_Run1_Internal_TRet_T0_0;

		// Token: 0x040009AB RID: 2475
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid1_Internal_Void_T0_0;

		// Token: 0x040009AC RID: 2476
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun1_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009AD RID: 2477
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid1_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009AE RID: 2478
		private static readonly IntPtr NativeMethodInfoPtr_Run2_Internal_TRet_T0_T1_0;

		// Token: 0x040009AF RID: 2479
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid2_Internal_Void_T0_T1_0;

		// Token: 0x040009B0 RID: 2480
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun2_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009B1 RID: 2481
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid2_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009B2 RID: 2482
		private static readonly IntPtr NativeMethodInfoPtr_Run3_Internal_TRet_T0_T1_T2_0;

		// Token: 0x040009B3 RID: 2483
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid3_Internal_Void_T0_T1_T2_0;

		// Token: 0x040009B4 RID: 2484
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun3_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009B5 RID: 2485
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid3_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeMethodInfoPtr_Run4_Internal_TRet_T0_T1_T2_T3_0;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid4_Internal_Void_T0_T1_T2_T3_0;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun4_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid4_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeMethodInfoPtr_Run5_Internal_TRet_T0_T1_T2_T3_T4_0;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid5_Internal_Void_T0_T1_T2_T3_T4_0;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun5_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid5_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeMethodInfoPtr_Run6_Internal_TRet_T0_T1_T2_T3_T4_T5_0;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid6_Internal_Void_T0_T1_T2_T3_T4_T5_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun6_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid6_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeMethodInfoPtr_Run7_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_0;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid7_Internal_Void_T0_T1_T2_T3_T4_T5_T6_0;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun7_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid7_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_Run8_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid8_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun8_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid8_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_Run9_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid9_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun9_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid9_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_Run10_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid10_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun10_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid10_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr_Run11_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid11_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0;

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun11_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid11_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009D6 RID: 2518
		private static readonly IntPtr NativeMethodInfoPtr_Run12_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0;

		// Token: 0x040009D7 RID: 2519
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid12_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0;

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun12_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid12_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_Run13_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid13_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun13_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid13_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_Run14_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid14_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun14_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009E1 RID: 2529
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid14_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009E2 RID: 2530
		private static readonly IntPtr NativeMethodInfoPtr_Run15_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0;

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid15_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeMethodInfoPtr_MakeRun15_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunVoid15_Internal_Static_Delegate_LightLambda_0;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LightDelegateCreator_Il2CppReferenceArray_1_IStrongBox_0;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugView_Internal_get_String_0;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeMethodInfoPtr_GetRunDelegateCtor_Private_Static_Func_2_LightLambda_Delegate_Type_0;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeMethodInfoPtr_MakeRunDelegateCtor_Private_Static_Func_2_LightLambda_Delegate_Type_0;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomDelegate_Private_Delegate_Type_0;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeMethodInfoPtr_MakeDelegate_Internal_Delegate_Type_0;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeMethodInfoPtr_MakeFrame_Private_InterpretedFrame_0;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeMethodInfoPtr_RunVoidRef2_Internal_Void_byref_T0_byref_T1_0;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeMethodInfoPtr_RunVoid_Public_Object_Il2CppReferenceArray_1_Object_0;

		// Token: 0x02000276 RID: 630
		public class DebugViewPrinter : Object
		{
			// Token: 0x060018C8 RID: 6344 RVA: 0x00076514 File Offset: 0x00074714
			// Note: this type is marked as 'beforefieldinit'.
			static DebugViewPrinter()
			{
				Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, "DebugViewPrinter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr);
				LightLambda.DebugViewPrinter.NativeFieldInfoPtr__interpreter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, "_interpreter");
				LightLambda.DebugViewPrinter.NativeFieldInfoPtr__tryStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, "_tryStart");
				LightLambda.DebugViewPrinter.NativeFieldInfoPtr__handlerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, "_handlerEnter");
				LightLambda.DebugViewPrinter.NativeFieldInfoPtr__handlerExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, "_handlerExit");
				LightLambda.DebugViewPrinter.NativeFieldInfoPtr__indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, "_indent");
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr__ctor_Public_Void_Interpreter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665739);
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr_Analyze_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665740);
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr_AddTryStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665741);
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr_AddHandlerExit_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665742);
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr_Indent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665743);
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr_Dedent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665744);
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665745);
				LightLambda.DebugViewPrinter.NativeMethodInfoPtr_EmitExits_Private_Void_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr, 100665746);
			}

			// Token: 0x060018C9 RID: 6345 RVA: 0x00076644 File Offset: 0x00074844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022468, XrefRangeEnd = 1022494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DebugViewPrinter(Interpreter interpreter)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightLambda.DebugViewPrinter>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(interpreter);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.DebugViewPrinter.NativeMethodInfoPtr__ctor_Public_Void_Interpreter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018CA RID: 6346 RVA: 0x00076690 File Offset: 0x00074890
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1022525, RefRangeEnd = 1022527, XrefRangeStart = 1022494, XrefRangeEnd = 1022525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Analyze()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.DebugViewPrinter.NativeMethodInfoPtr_Analyze_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018CB RID: 6347 RVA: 0x000766C4 File Offset: 0x000748C4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1022534, RefRangeEnd = 1022536, XrefRangeStart = 1022527, XrefRangeEnd = 1022534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddTryStart(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.DebugViewPrinter.NativeMethodInfoPtr_AddTryStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018CC RID: 6348 RVA: 0x00076704 File Offset: 0x00074904
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1022543, RefRangeEnd = 1022549, XrefRangeStart = 1022536, XrefRangeEnd = 1022543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddHandlerExit(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.DebugViewPrinter.NativeMethodInfoPtr_AddHandlerExit_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018CD RID: 6349 RVA: 0x00076744 File Offset: 0x00074944
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1022552, RefRangeEnd = 1022554, XrefRangeStart = 1022549, XrefRangeEnd = 1022552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Indent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.DebugViewPrinter.NativeMethodInfoPtr_Indent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018CE RID: 6350 RVA: 0x00076778 File Offset: 0x00074978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022554, XrefRangeEnd = 1022557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Dedent()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.DebugViewPrinter.NativeMethodInfoPtr_Dedent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018CF RID: 6351 RVA: 0x000767AC File Offset: 0x000749AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022557, XrefRangeEnd = 1022630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightLambda.DebugViewPrinter.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060018D0 RID: 6352 RVA: 0x000767F0 File Offset: 0x000749F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1022639, RefRangeEnd = 1022641, XrefRangeStart = 1022630, XrefRangeEnd = 1022639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EmitExits(StringBuilder sb, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.DebugViewPrinter.NativeMethodInfoPtr_EmitExits_Private_Void_StringBuilder_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018D1 RID: 6353 RVA: 0x00009EF9 File Offset: 0x000080F9
			public DebugViewPrinter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00076840 File Offset: 0x00074A40
			// (set) Token: 0x060018D3 RID: 6355 RVA: 0x00009F02 File Offset: 0x00008102
			public unsafe Interpreter _interpreter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__interpreter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpreter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__interpreter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x060018D4 RID: 6356 RVA: 0x00076870 File Offset: 0x00074A70
			// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00009F21 File Offset: 0x00008121
			public unsafe Dictionary<int, int> _tryStart
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__tryStart);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__tryStart), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x060018D6 RID: 6358 RVA: 0x000768A0 File Offset: 0x00074AA0
			// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00009F40 File Offset: 0x00008140
			public unsafe Dictionary<int, string> _handlerEnter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__handlerEnter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__handlerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BB RID: 1723
			// (get) Token: 0x060018D8 RID: 6360 RVA: 0x000768D0 File Offset: 0x00074AD0
			// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00009F5F File Offset: 0x0000815F
			public unsafe Dictionary<int, int> _handlerExit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__handlerExit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__handlerExit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BC RID: 1724
			// (get) Token: 0x060018DA RID: 6362 RVA: 0x00076900 File Offset: 0x00074B00
			// (set) Token: 0x060018DB RID: 6363 RVA: 0x00009F7E File Offset: 0x0000817E
			public unsafe string _indent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__indent);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.DebugViewPrinter.NativeFieldInfoPtr__indent), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040010FD RID: 4349
			private static readonly IntPtr NativeFieldInfoPtr__interpreter;

			// Token: 0x040010FE RID: 4350
			private static readonly IntPtr NativeFieldInfoPtr__tryStart;

			// Token: 0x040010FF RID: 4351
			private static readonly IntPtr NativeFieldInfoPtr__handlerEnter;

			// Token: 0x04001100 RID: 4352
			private static readonly IntPtr NativeFieldInfoPtr__handlerExit;

			// Token: 0x04001101 RID: 4353
			private static readonly IntPtr NativeFieldInfoPtr__indent;

			// Token: 0x04001102 RID: 4354
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Interpreter_0;

			// Token: 0x04001103 RID: 4355
			private static readonly IntPtr NativeMethodInfoPtr_Analyze_Private_Void_0;

			// Token: 0x04001104 RID: 4356
			private static readonly IntPtr NativeMethodInfoPtr_AddTryStart_Private_Void_Int32_0;

			// Token: 0x04001105 RID: 4357
			private static readonly IntPtr NativeMethodInfoPtr_AddHandlerExit_Private_Void_Int32_0;

			// Token: 0x04001106 RID: 4358
			private static readonly IntPtr NativeMethodInfoPtr_Indent_Private_Void_0;

			// Token: 0x04001107 RID: 4359
			private static readonly IntPtr NativeMethodInfoPtr_Dedent_Private_Void_0;

			// Token: 0x04001108 RID: 4360
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04001109 RID: 4361
			private static readonly IntPtr NativeMethodInfoPtr_EmitExits_Private_Void_StringBuilder_Int32_0;
		}

		// Token: 0x02000277 RID: 631
		[ObfuscatedName("System.Linq.Expressions.Interpreter.LightLambda+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : Object
		{
			// Token: 0x060018DC RID: 6364 RVA: 0x00076928 File Offset: 0x00074B28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<LightLambda.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightLambda>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightLambda.__c__DisplayClass74_0>.NativeClassPtr);
				LightLambda.__c__DisplayClass74_0.NativeFieldInfoPtr_targetMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda.__c__DisplayClass74_0>.NativeClassPtr, "targetMethod");
				LightLambda.__c__DisplayClass74_0.NativeFieldInfoPtr_delegateType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightLambda.__c__DisplayClass74_0>.NativeClassPtr, "delegateType");
				LightLambda.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.__c__DisplayClass74_0>.NativeClassPtr, 100665747);
				LightLambda.__c__DisplayClass74_0.NativeMethodInfoPtr__MakeRunDelegateCtor_b__0_Internal_Delegate_LightLambda_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightLambda.__c__DisplayClass74_0>.NativeClassPtr, 100665748);
			}

			// Token: 0x060018DD RID: 6365 RVA: 0x000769A4 File Offset: 0x00074BA4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightLambda.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018DE RID: 6366 RVA: 0x000769E0 File Offset: 0x00074BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022641, XrefRangeEnd = 1022656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Delegate _MakeRunDelegateCtor_b__0(LightLambda lambda)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(lambda);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightLambda.__c__DisplayClass74_0.NativeMethodInfoPtr__MakeRunDelegateCtor_b__0_Internal_Delegate_LightLambda_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
				}
			}

			// Token: 0x060018DF RID: 6367 RVA: 0x00009F9D File Offset: 0x0000819D
			public __c__DisplayClass74_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006BD RID: 1725
			// (get) Token: 0x060018E0 RID: 6368 RVA: 0x00076A30 File Offset: 0x00074C30
			// (set) Token: 0x060018E1 RID: 6369 RVA: 0x00009FA6 File Offset: 0x000081A6
			public unsafe MethodInfo targetMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.__c__DisplayClass74_0.NativeFieldInfoPtr_targetMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.__c__DisplayClass74_0.NativeFieldInfoPtr_targetMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006BE RID: 1726
			// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00076A60 File Offset: 0x00074C60
			// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00009FC5 File Offset: 0x000081C5
			public unsafe Type delegateType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.__c__DisplayClass74_0.NativeFieldInfoPtr_delegateType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightLambda.__c__DisplayClass74_0.NativeFieldInfoPtr_delegateType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400110A RID: 4362
			private static readonly IntPtr NativeFieldInfoPtr_targetMethod;

			// Token: 0x0400110B RID: 4363
			private static readonly IntPtr NativeFieldInfoPtr_delegateType;

			// Token: 0x0400110C RID: 4364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400110D RID: 4365
			private static readonly IntPtr NativeMethodInfoPtr__MakeRunDelegateCtor_b__0_Internal_Delegate_LightLambda_0;
		}

		// Token: 0x02000278 RID: 632
		private sealed class MethodInfoStoreGeneric_Run0_Internal_TRet_0<TRet>
		{
			// Token: 0x0400110E RID: 4366
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run0_Internal_TRet_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr)) }))));
		}

		// Token: 0x02000279 RID: 633
		private sealed class MethodInfoStoreGeneric_MakeRun0_Internal_Static_Delegate_LightLambda_0<TRet>
		{
			// Token: 0x0400110F RID: 4367
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun0_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr)) }))));
		}

		// Token: 0x0200027A RID: 634
		private sealed class MethodInfoStoreGeneric_Run1_Internal_TRet_T0_0<T0, TRet>
		{
			// Token: 0x04001110 RID: 4368
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run1_Internal_TRet_T0_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200027B RID: 635
		private sealed class MethodInfoStoreGeneric_RunVoid1_Internal_Void_T0_0<T0>
		{
			// Token: 0x04001111 RID: 4369
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid1_Internal_Void_T0_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)) }))));
		}

		// Token: 0x0200027C RID: 636
		private sealed class MethodInfoStoreGeneric_MakeRun1_Internal_Static_Delegate_LightLambda_0<T0, TRet>
		{
			// Token: 0x04001112 RID: 4370
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun1_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200027D RID: 637
		private sealed class MethodInfoStoreGeneric_MakeRunVoid1_Internal_Static_Delegate_LightLambda_0<T0>
		{
			// Token: 0x04001113 RID: 4371
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid1_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)) }))));
		}

		// Token: 0x0200027E RID: 638
		private sealed class MethodInfoStoreGeneric_Run2_Internal_TRet_T0_T1_0<T0, T1, TRet>
		{
			// Token: 0x04001114 RID: 4372
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run2_Internal_TRet_T0_T1_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200027F RID: 639
		private sealed class MethodInfoStoreGeneric_RunVoid2_Internal_Void_T0_T1_0<T0, T1>
		{
			// Token: 0x04001115 RID: 4373
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid2_Internal_Void_T0_T1_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000280 RID: 640
		private sealed class MethodInfoStoreGeneric_MakeRun2_Internal_Static_Delegate_LightLambda_0<T0, T1, TRet>
		{
			// Token: 0x04001116 RID: 4374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun2_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000281 RID: 641
		private sealed class MethodInfoStoreGeneric_MakeRunVoid2_Internal_Static_Delegate_LightLambda_0<T0, T1>
		{
			// Token: 0x04001117 RID: 4375
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid2_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000282 RID: 642
		private sealed class MethodInfoStoreGeneric_Run3_Internal_TRet_T0_T1_T2_0<T0, T1, T2, TRet>
		{
			// Token: 0x04001118 RID: 4376
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run3_Internal_TRet_T0_T1_T2_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000283 RID: 643
		private sealed class MethodInfoStoreGeneric_RunVoid3_Internal_Void_T0_T1_T2_0<T0, T1, T2>
		{
			// Token: 0x04001119 RID: 4377
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid3_Internal_Void_T0_T1_T2_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000284 RID: 644
		private sealed class MethodInfoStoreGeneric_MakeRun3_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, TRet>
		{
			// Token: 0x0400111A RID: 4378
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun3_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000285 RID: 645
		private sealed class MethodInfoStoreGeneric_MakeRunVoid3_Internal_Static_Delegate_LightLambda_0<T0, T1, T2>
		{
			// Token: 0x0400111B RID: 4379
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid3_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000286 RID: 646
		private sealed class MethodInfoStoreGeneric_Run4_Internal_TRet_T0_T1_T2_T3_0<T0, T1, T2, T3, TRet>
		{
			// Token: 0x0400111C RID: 4380
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run4_Internal_TRet_T0_T1_T2_T3_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000287 RID: 647
		private sealed class MethodInfoStoreGeneric_RunVoid4_Internal_Void_T0_T1_T2_T3_0<T0, T1, T2, T3>
		{
			// Token: 0x0400111D RID: 4381
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid4_Internal_Void_T0_T1_T2_T3_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000288 RID: 648
		private sealed class MethodInfoStoreGeneric_MakeRun4_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, TRet>
		{
			// Token: 0x0400111E RID: 4382
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun4_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000289 RID: 649
		private sealed class MethodInfoStoreGeneric_MakeRunVoid4_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3>
		{
			// Token: 0x0400111F RID: 4383
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid4_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200028A RID: 650
		private sealed class MethodInfoStoreGeneric_Run5_Internal_TRet_T0_T1_T2_T3_T4_0<T0, T1, T2, T3, T4, TRet>
		{
			// Token: 0x04001120 RID: 4384
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run5_Internal_TRet_T0_T1_T2_T3_T4_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200028B RID: 651
		private sealed class MethodInfoStoreGeneric_RunVoid5_Internal_Void_T0_T1_T2_T3_T4_0<T0, T1, T2, T3, T4>
		{
			// Token: 0x04001121 RID: 4385
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid5_Internal_Void_T0_T1_T2_T3_T4_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200028C RID: 652
		private sealed class MethodInfoStoreGeneric_MakeRun5_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, TRet>
		{
			// Token: 0x04001122 RID: 4386
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun5_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200028D RID: 653
		private sealed class MethodInfoStoreGeneric_MakeRunVoid5_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4>
		{
			// Token: 0x04001123 RID: 4387
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid5_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200028E RID: 654
		private sealed class MethodInfoStoreGeneric_Run6_Internal_TRet_T0_T1_T2_T3_T4_T5_0<T0, T1, T2, T3, T4, T5, TRet>
		{
			// Token: 0x04001124 RID: 4388
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run6_Internal_TRet_T0_T1_T2_T3_T4_T5_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200028F RID: 655
		private sealed class MethodInfoStoreGeneric_RunVoid6_Internal_Void_T0_T1_T2_T3_T4_T5_0<T0, T1, T2, T3, T4, T5>
		{
			// Token: 0x04001125 RID: 4389
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid6_Internal_Void_T0_T1_T2_T3_T4_T5_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000290 RID: 656
		private sealed class MethodInfoStoreGeneric_MakeRun6_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, TRet>
		{
			// Token: 0x04001126 RID: 4390
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun6_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000291 RID: 657
		private sealed class MethodInfoStoreGeneric_MakeRunVoid6_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5>
		{
			// Token: 0x04001127 RID: 4391
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid6_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000292 RID: 658
		private sealed class MethodInfoStoreGeneric_Run7_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_0<T0, T1, T2, T3, T4, T5, T6, TRet>
		{
			// Token: 0x04001128 RID: 4392
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run7_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000293 RID: 659
		private sealed class MethodInfoStoreGeneric_RunVoid7_Internal_Void_T0_T1_T2_T3_T4_T5_T6_0<T0, T1, T2, T3, T4, T5, T6>
		{
			// Token: 0x04001129 RID: 4393
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid7_Internal_Void_T0_T1_T2_T3_T4_T5_T6_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000294 RID: 660
		private sealed class MethodInfoStoreGeneric_MakeRun7_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, TRet>
		{
			// Token: 0x0400112A RID: 4394
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun7_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000295 RID: 661
		private sealed class MethodInfoStoreGeneric_MakeRunVoid7_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6>
		{
			// Token: 0x0400112B RID: 4395
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid7_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000296 RID: 662
		private sealed class MethodInfoStoreGeneric_Run8_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_0<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
		{
			// Token: 0x0400112C RID: 4396
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run8_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000297 RID: 663
		private sealed class MethodInfoStoreGeneric_RunVoid8_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_0<T0, T1, T2, T3, T4, T5, T6, T7>
		{
			// Token: 0x0400112D RID: 4397
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid8_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000298 RID: 664
		private sealed class MethodInfoStoreGeneric_MakeRun8_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, TRet>
		{
			// Token: 0x0400112E RID: 4398
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun8_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000299 RID: 665
		private sealed class MethodInfoStoreGeneric_MakeRunVoid8_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7>
		{
			// Token: 0x0400112F RID: 4399
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid8_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200029A RID: 666
		private sealed class MethodInfoStoreGeneric_Run9_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
		{
			// Token: 0x04001130 RID: 4400
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run9_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200029B RID: 667
		private sealed class MethodInfoStoreGeneric_RunVoid9_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_0<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		{
			// Token: 0x04001131 RID: 4401
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid9_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200029C RID: 668
		private sealed class MethodInfoStoreGeneric_MakeRun9_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>
		{
			// Token: 0x04001132 RID: 4402
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun9_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200029D RID: 669
		private sealed class MethodInfoStoreGeneric_MakeRunVoid9_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8>
		{
			// Token: 0x04001133 RID: 4403
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid9_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200029E RID: 670
		private sealed class MethodInfoStoreGeneric_Run10_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>
		{
			// Token: 0x04001134 RID: 4404
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run10_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200029F RID: 671
		private sealed class MethodInfoStoreGeneric_RunVoid10_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		{
			// Token: 0x04001135 RID: 4405
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid10_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A0 RID: 672
		private sealed class MethodInfoStoreGeneric_MakeRun10_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>
		{
			// Token: 0x04001136 RID: 4406
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun10_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A1 RID: 673
		private sealed class MethodInfoStoreGeneric_MakeRunVoid10_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>
		{
			// Token: 0x04001137 RID: 4407
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid10_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A2 RID: 674
		private sealed class MethodInfoStoreGeneric_Run11_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>
		{
			// Token: 0x04001138 RID: 4408
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run11_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A3 RID: 675
		private sealed class MethodInfoStoreGeneric_RunVoid11_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
		{
			// Token: 0x04001139 RID: 4409
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid11_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A4 RID: 676
		private sealed class MethodInfoStoreGeneric_MakeRun11_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>
		{
			// Token: 0x0400113A RID: 4410
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun11_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A5 RID: 677
		private sealed class MethodInfoStoreGeneric_MakeRunVoid11_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
		{
			// Token: 0x0400113B RID: 4411
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid11_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A6 RID: 678
		private sealed class MethodInfoStoreGeneric_Run12_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>
		{
			// Token: 0x0400113C RID: 4412
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run12_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A7 RID: 679
		private sealed class MethodInfoStoreGeneric_RunVoid12_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
		{
			// Token: 0x0400113D RID: 4413
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid12_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A8 RID: 680
		private sealed class MethodInfoStoreGeneric_MakeRun12_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>
		{
			// Token: 0x0400113E RID: 4414
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun12_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002A9 RID: 681
		private sealed class MethodInfoStoreGeneric_MakeRunVoid12_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
		{
			// Token: 0x0400113F RID: 4415
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid12_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002AA RID: 682
		private sealed class MethodInfoStoreGeneric_Run13_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>
		{
			// Token: 0x04001140 RID: 4416
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run13_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002AB RID: 683
		private sealed class MethodInfoStoreGeneric_RunVoid13_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
		{
			// Token: 0x04001141 RID: 4417
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid13_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002AC RID: 684
		private sealed class MethodInfoStoreGeneric_MakeRun13_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>
		{
			// Token: 0x04001142 RID: 4418
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun13_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002AD RID: 685
		private sealed class MethodInfoStoreGeneric_MakeRunVoid13_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
		{
			// Token: 0x04001143 RID: 4419
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid13_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002AE RID: 686
		private sealed class MethodInfoStoreGeneric_Run14_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>
		{
			// Token: 0x04001144 RID: 4420
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run14_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002AF RID: 687
		private sealed class MethodInfoStoreGeneric_RunVoid14_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
		{
			// Token: 0x04001145 RID: 4421
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid14_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002B0 RID: 688
		private sealed class MethodInfoStoreGeneric_MakeRun14_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>
		{
			// Token: 0x04001146 RID: 4422
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun14_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002B1 RID: 689
		private sealed class MethodInfoStoreGeneric_MakeRunVoid14_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
		{
			// Token: 0x04001147 RID: 4423
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid14_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002B2 RID: 690
		private sealed class MethodInfoStoreGeneric_Run15_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>
		{
			// Token: 0x04001148 RID: 4424
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_Run15_Internal_TRet_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T14>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002B3 RID: 691
		private sealed class MethodInfoStoreGeneric_RunVoid15_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
		{
			// Token: 0x04001149 RID: 4425
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoid15_Internal_Void_T0_T1_T2_T3_T4_T5_T6_T7_T8_T9_T10_T11_T12_T13_T14_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T14>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002B4 RID: 692
		private sealed class MethodInfoStoreGeneric_MakeRun15_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>
		{
			// Token: 0x0400114A RID: 4426
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRun15_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T14>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRet>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002B5 RID: 693
		private sealed class MethodInfoStoreGeneric_MakeRunVoid15_Internal_Static_Delegate_LightLambda_0<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
		{
			// Token: 0x0400114B RID: 4427
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_MakeRunVoid15_Internal_Static_Delegate_LightLambda_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T9>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T10>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T11>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T12>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T13>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T14>.NativeClassPtr))
			}))));
		}

		// Token: 0x020002B6 RID: 694
		private sealed class MethodInfoStoreGeneric_RunVoidRef2_Internal_Void_byref_T0_byref_T1_0<T0, T1>
		{
			// Token: 0x0400114C RID: 4428
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightLambda.NativeMethodInfoPtr_RunVoidRef2_Internal_Void_byref_T0_byref_T1_0, Il2CppClassPointerStore<LightLambda>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			}))));
		}
	}
}
