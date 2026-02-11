using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace dwd.core.client
{
	// Token: 0x020001EA RID: 490
	public class ExitApplicationControl : MonoBehaviour
	{
		// Token: 0x06001AB1 RID: 6833 RVA: 0x0007E45C File Offset: 0x0007C65C
		// Note: this type is marked as 'beforefieldinit'.
		static ExitApplicationControl()
		{
			Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.client", "ExitApplicationControl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr);
			ExitApplicationControl.NativeFieldInfoPtr_quitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, "quitting");
			ExitApplicationControl.NativeFieldInfoPtr_quitApproved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, "quitApproved");
			ExitApplicationControl.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667539);
			ExitApplicationControl.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667540);
			ExitApplicationControl.NativeMethodInfoPtr_wantsToQuit_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667541);
			ExitApplicationControl.NativeMethodInfoPtr_RequestQuit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667542);
			ExitApplicationControl.NativeMethodInfoPtr_ForceQuit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667543);
			ExitApplicationControl.NativeMethodInfoPtr_requestQuit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667544);
			ExitApplicationControl.NativeMethodInfoPtr_safeQuit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667545);
			ExitApplicationControl.NativeMethodInfoPtr_dispatchBlockingQuit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667546);
			ExitApplicationControl.NativeMethodInfoPtr_dispatchQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667547);
			ExitApplicationControl.NativeMethodInfoPtr_exitApplication_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667548);
			ExitApplicationControl.NativeMethodInfoPtr_GlobalForceQuit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667549);
			ExitApplicationControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, 100667550);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0007E5A4 File Offset: 0x0007C7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884021, XrefRangeEnd = 884031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0007E5D8 File Offset: 0x0007C7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884031, XrefRangeEnd = 884041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0007E60C File Offset: 0x0007C80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884041, XrefRangeEnd = 884047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool wantsToQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_wantsToQuit_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0007E648 File Offset: 0x0007C848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884047, XrefRangeEnd = 884053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_RequestQuit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0007E67C File Offset: 0x0007C87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 884059, RefRangeEnd = 884060, XrefRangeStart = 884053, XrefRangeEnd = 884059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_ForceQuit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0007E6B0 File Offset: 0x0007C8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884060, XrefRangeEnd = 884065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator requestQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_requestQuit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0007E6F0 File Offset: 0x0007C8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884065, XrefRangeEnd = 884070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator safeQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_safeQuit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0007E730 File Offset: 0x0007C930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884070, XrefRangeEnd = 884075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator dispatchBlockingQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_dispatchBlockingQuit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0007E770 File Offset: 0x0007C970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884075, XrefRangeEnd = 884122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dispatchQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_dispatchQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0007E7A4 File Offset: 0x0007C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884122, XrefRangeEnd = 884129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void exitApplication()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_exitApplication_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0007E7CC File Offset: 0x0007C9CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 884136, RefRangeEnd = 884139, XrefRangeStart = 884129, XrefRangeEnd = 884136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GlobalForceQuit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr_GlobalForceQuit_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0007E7F4 File Offset: 0x0007C9F4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitApplicationControl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0000B7DC File Offset: 0x000099DC
		public ExitApplicationControl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x0007E830 File Offset: 0x0007CA30
		// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0000B7E5 File Offset: 0x000099E5
		public unsafe bool quitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl.NativeFieldInfoPtr_quitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl.NativeFieldInfoPtr_quitting)) = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0007E858 File Offset: 0x0007CA58
		// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0000B800 File Offset: 0x00009A00
		public unsafe bool quitApproved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl.NativeFieldInfoPtr_quitApproved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl.NativeFieldInfoPtr_quitApproved)) = value;
			}
		}

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeFieldInfoPtr_quitting;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeFieldInfoPtr_quitApproved;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_wantsToQuit_Private_Boolean_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_RequestQuit_Public_Void_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_ForceQuit_Public_Void_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_requestQuit_Private_IEnumerator_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_safeQuit_Private_IEnumerator_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_dispatchBlockingQuit_Private_IEnumerator_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_dispatchQuit_Private_Void_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_exitApplication_Private_Static_Void_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_GlobalForceQuit_Public_Static_Void_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200037E RID: 894
		[ObfuscatedName("dwd.core.client.ExitApplicationControl+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060027E5 RID: 10213 RVA: 0x000A8FE8 File Offset: 0x000A71E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr);
				ExitApplicationControl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, "<>9");
				ExitApplicationControl.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, "<>9__9_0");
				ExitApplicationControl.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, "<>9__9_1");
				ExitApplicationControl.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, "<>9__10_0");
				ExitApplicationControl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, 100667552);
				ExitApplicationControl.__c.NativeMethodInfoPtr__dispatchBlockingQuit_b__9_0_Internal_IEnumerable_1_IBlockingApplicationQuitHandler_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, 100667553);
				ExitApplicationControl.__c.NativeMethodInfoPtr__dispatchBlockingQuit_b__9_1_Internal_Command_IBlockingApplicationQuitHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, 100667554);
				ExitApplicationControl.__c.NativeMethodInfoPtr__dispatchQuit_b__10_0_Internal_IEnumerable_1_IApplicationQuitHandler_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr, 100667555);
			}

			// Token: 0x060027E6 RID: 10214 RVA: 0x000A90B4 File Offset: 0x000A72B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationControl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027E7 RID: 10215 RVA: 0x000A90F0 File Offset: 0x000A72F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883927, XrefRangeEnd = 883931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IBlockingApplicationQuitHandler> _dispatchBlockingQuit_b__9_0(GameObject gameObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.__c.NativeMethodInfoPtr__dispatchBlockingQuit_b__9_0_Internal_IEnumerable_1_IBlockingApplicationQuitHandler_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IBlockingApplicationQuitHandler>>(intPtr3) : null;
				}
			}

			// Token: 0x060027E8 RID: 10216 RVA: 0x000A9140 File Offset: 0x000A7340
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883931, XrefRangeEnd = 883935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Command _dispatchBlockingQuit_b__9_1(IBlockingApplicationQuitHandler x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.__c.NativeMethodInfoPtr__dispatchBlockingQuit_b__9_1_Internal_Command_IBlockingApplicationQuitHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x060027E9 RID: 10217 RVA: 0x000A9190 File Offset: 0x000A7390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883935, XrefRangeEnd = 883939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<IApplicationQuitHandler> _dispatchQuit_b__10_0(GameObject gameObject)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl.__c.NativeMethodInfoPtr__dispatchQuit_b__10_0_Internal_IEnumerable_1_IApplicationQuitHandler_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IApplicationQuitHandler>>(intPtr3) : null;
				}
			}

			// Token: 0x060027EA RID: 10218 RVA: 0x00012175 File Offset: 0x00010375
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x060027EB RID: 10219 RVA: 0x000A91E0 File Offset: 0x000A73E0
			// (set) Token: 0x060027EC RID: 10220 RVA: 0x0001217E File Offset: 0x0001037E
			public unsafe static ExitApplicationControl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExitApplicationControl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x060027ED RID: 10221 RVA: 0x000A9208 File Offset: 0x000A7408
			// (set) Token: 0x060027EE RID: 10222 RVA: 0x00012190 File Offset: 0x00010390
			public unsafe static Func<GameObject, IEnumerable<IBlockingApplicationQuitHandler>> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, IEnumerable<IBlockingApplicationQuitHandler>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x060027EF RID: 10223 RVA: 0x000A9230 File Offset: 0x000A7430
			// (set) Token: 0x060027F0 RID: 10224 RVA: 0x000121A2 File Offset: 0x000103A2
			public unsafe static Func<IBlockingApplicationQuitHandler, Command> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IBlockingApplicationQuitHandler, Command>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000A9258 File Offset: 0x000A7458
			// (set) Token: 0x060027F2 RID: 10226 RVA: 0x000121B4 File Offset: 0x000103B4
			public unsafe static Func<GameObject, IEnumerable<IApplicationQuitHandler>> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, IEnumerable<IApplicationQuitHandler>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ExitApplicationControl.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B1C RID: 6940
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001B1D RID: 6941
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04001B1E RID: 6942
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04001B1F RID: 6943
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04001B20 RID: 6944
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001B21 RID: 6945
			private static readonly IntPtr NativeMethodInfoPtr__dispatchBlockingQuit_b__9_0_Internal_IEnumerable_1_IBlockingApplicationQuitHandler_GameObject_0;

			// Token: 0x04001B22 RID: 6946
			private static readonly IntPtr NativeMethodInfoPtr__dispatchBlockingQuit_b__9_1_Internal_Command_IBlockingApplicationQuitHandler_0;

			// Token: 0x04001B23 RID: 6947
			private static readonly IntPtr NativeMethodInfoPtr__dispatchQuit_b__10_0_Internal_IEnumerable_1_IApplicationQuitHandler_GameObject_0;
		}

		// Token: 0x0200037F RID: 895
		[ObfuscatedName("dwd.core.client.ExitApplicationControl+<dispatchBlockingQuit>d__9")]
		public sealed class _dispatchBlockingQuit_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x060027F3 RID: 10227 RVA: 0x000A9280 File Offset: 0x000A7480
			// Note: this type is marked as 'beforefieldinit'.
			static _dispatchBlockingQuit_d__9()
			{
				Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, "<dispatchBlockingQuit>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr);
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, "<>1__state");
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, "<>2__current");
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, "<>4__this");
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, 100667556);
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, 100667557);
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, 100667558);
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, 100667559);
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, 100667560);
				ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr, 100667561);
			}

			// Token: 0x060027F4 RID: 10228 RVA: 0x000A9360 File Offset: 0x000A7560
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _dispatchBlockingQuit_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationControl._dispatchBlockingQuit_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060027F5 RID: 10229 RVA: 0x000A93A8 File Offset: 0x000A75A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060027F6 RID: 10230 RVA: 0x000A93DC File Offset: 0x000A75DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883939, XrefRangeEnd = 883985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x060027F7 RID: 10231 RVA: 0x000A9418 File Offset: 0x000A7618
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027F8 RID: 10232 RVA: 0x000A9458 File Offset: 0x000A7658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883985, XrefRangeEnd = 883990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000A948C File Offset: 0x000A768C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060027FA RID: 10234 RVA: 0x000121C6 File Offset: 0x000103C6
			public _dispatchBlockingQuit_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x060027FB RID: 10235 RVA: 0x000A94CC File Offset: 0x000A76CC
			// (set) Token: 0x060027FC RID: 10236 RVA: 0x000121CF File Offset: 0x000103CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x060027FD RID: 10237 RVA: 0x000A94F4 File Offset: 0x000A76F4
			// (set) Token: 0x060027FE RID: 10238 RVA: 0x000121EA File Offset: 0x000103EA
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x060027FF RID: 10239 RVA: 0x000A9524 File Offset: 0x000A7724
			// (set) Token: 0x06002800 RID: 10240 RVA: 0x00012209 File Offset: 0x00010409
			public unsafe ExitApplicationControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExitApplicationControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._dispatchBlockingQuit_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B24 RID: 6948
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B25 RID: 6949
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B26 RID: 6950
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B27 RID: 6951
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B28 RID: 6952
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B29 RID: 6953
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B2A RID: 6954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B2B RID: 6955
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B2C RID: 6956
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000380 RID: 896
		[ObfuscatedName("dwd.core.client.ExitApplicationControl+<requestQuit>d__7")]
		public sealed class _requestQuit_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06002801 RID: 10241 RVA: 0x000A9554 File Offset: 0x000A7754
			// Note: this type is marked as 'beforefieldinit'.
			static _requestQuit_d__7()
			{
				Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, "<requestQuit>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr);
				ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, "<>1__state");
				ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, "<>2__current");
				ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, "<>4__this");
				ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, "<request>5__2");
				ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, 100667562);
				ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, 100667563);
				ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, 100667564);
				ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, 100667565);
				ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, 100667566);
				ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr, 100667567);
			}

			// Token: 0x06002802 RID: 10242 RVA: 0x000A9648 File Offset: 0x000A7848
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _requestQuit_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationControl._requestQuit_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002803 RID: 10243 RVA: 0x000A9690 File Offset: 0x000A7890
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002804 RID: 10244 RVA: 0x000A96C4 File Offset: 0x000A78C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 883990, XrefRangeEnd = 884005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06002805 RID: 10245 RVA: 0x000A9700 File Offset: 0x000A7900
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002806 RID: 10246 RVA: 0x000A9740 File Offset: 0x000A7940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884005, XrefRangeEnd = 884010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06002807 RID: 10247 RVA: 0x000A9774 File Offset: 0x000A7974
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._requestQuit_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002808 RID: 10248 RVA: 0x00012228 File Offset: 0x00010428
			public _requestQuit_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06002809 RID: 10249 RVA: 0x000A97B4 File Offset: 0x000A79B4
			// (set) Token: 0x0600280A RID: 10250 RVA: 0x00012231 File Offset: 0x00010431
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x0600280B RID: 10251 RVA: 0x000A97DC File Offset: 0x000A79DC
			// (set) Token: 0x0600280C RID: 10252 RVA: 0x0001224C File Offset: 0x0001044C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x0600280D RID: 10253 RVA: 0x000A980C File Offset: 0x000A7A0C
			// (set) Token: 0x0600280E RID: 10254 RVA: 0x0001226B File Offset: 0x0001046B
			public unsafe ExitApplicationControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExitApplicationControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x0600280F RID: 10255 RVA: 0x000A983C File Offset: 0x000A7A3C
			// (set) Token: 0x06002810 RID: 10256 RVA: 0x0001228A File Offset: 0x0001048A
			public unsafe ExitApplicationRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExitApplicationRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._requestQuit_d__7.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B2D RID: 6957
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B2E RID: 6958
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B2F RID: 6959
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B30 RID: 6960
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04001B31 RID: 6961
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B32 RID: 6962
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B33 RID: 6963
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B34 RID: 6964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B35 RID: 6965
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B36 RID: 6966
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000381 RID: 897
		[ObfuscatedName("dwd.core.client.ExitApplicationControl+<safeQuit>d__8")]
		public sealed class _safeQuit_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06002811 RID: 10257 RVA: 0x000A986C File Offset: 0x000A7A6C
			// Note: this type is marked as 'beforefieldinit'.
			static _safeQuit_d__8()
			{
				Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExitApplicationControl>.NativeClassPtr, "<safeQuit>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr);
				ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, "<>1__state");
				ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, "<>2__current");
				ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, "<>4__this");
				ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, 100667568);
				ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, 100667569);
				ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, 100667570);
				ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, 100667571);
				ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, 100667572);
				ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr, 100667573);
			}

			// Token: 0x06002812 RID: 10258 RVA: 0x000A994C File Offset: 0x000A7B4C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _safeQuit_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitApplicationControl._safeQuit_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002813 RID: 10259 RVA: 0x000A9994 File Offset: 0x000A7B94
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002814 RID: 10260 RVA: 0x000A99C8 File Offset: 0x000A7BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884010, XrefRangeEnd = 884016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06002815 RID: 10261 RVA: 0x000A9A04 File Offset: 0x000A7C04
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002816 RID: 10262 RVA: 0x000A9A44 File Offset: 0x000A7C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 884016, XrefRangeEnd = 884021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x06002817 RID: 10263 RVA: 0x000A9A78 File Offset: 0x000A7C78
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitApplicationControl._safeQuit_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002818 RID: 10264 RVA: 0x000122A9 File Offset: 0x000104A9
			public _safeQuit_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x06002819 RID: 10265 RVA: 0x000A9AB8 File Offset: 0x000A7CB8
			// (set) Token: 0x0600281A RID: 10266 RVA: 0x000122B2 File Offset: 0x000104B2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x0600281B RID: 10267 RVA: 0x000A9AE0 File Offset: 0x000A7CE0
			// (set) Token: 0x0600281C RID: 10268 RVA: 0x000122CD File Offset: 0x000104CD
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x0600281D RID: 10269 RVA: 0x000A9B10 File Offset: 0x000A7D10
			// (set) Token: 0x0600281E RID: 10270 RVA: 0x000122EC File Offset: 0x000104EC
			public unsafe ExitApplicationControl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExitApplicationControl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitApplicationControl._safeQuit_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001B37 RID: 6967
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001B38 RID: 6968
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001B39 RID: 6969
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001B3A RID: 6970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001B3B RID: 6971
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B3C RID: 6972
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001B3D RID: 6973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001B3E RID: 6974
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001B3F RID: 6975
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
