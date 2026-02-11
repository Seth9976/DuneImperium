using System;
using System.Runtime.InteropServices;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace match.prediction
{
	// Token: 0x0200007F RID: 127
	public class PrescienceAuthority : MonoBehaviour
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x00038168 File Offset: 0x00036368
		// Note: this type is marked as 'beforefieldinit'.
		static PrescienceAuthority()
		{
			Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "match.prediction", "PrescienceAuthority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr);
			PrescienceAuthority.NativeFieldInfoPtr_logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, "logging");
			PrescienceAuthority.NativeFieldInfoPtr_predictions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, "predictions");
			PrescienceAuthority.NativeMethodInfoPtr_get_Logging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664609);
			PrescienceAuthority.NativeMethodInfoPtr_set_Logging_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664610);
			PrescienceAuthority.NativeMethodInfoPtr_Add_Public_Void_IPrediction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664611);
			PrescienceAuthority.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664612);
			PrescienceAuthority.NativeMethodInfoPtr_GetRewindCommandAndClear_Public_Command_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664613);
			PrescienceAuthority.NativeMethodInfoPtr_log_Private_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664614);
			PrescienceAuthority.NativeMethodInfoPtr_log_Private_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664615);
			PrescienceAuthority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, 100664616);
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00038260 File Offset: 0x00036460
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x0003829C File Offset: 0x0003649C
		public unsafe bool Logging
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr_get_Logging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr_set_Logging_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000382DC File Offset: 0x000364DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861779, XrefRangeEnd = 861785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(IPrediction prediction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prediction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr_Add_Public_Void_IPrediction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00038320 File Offset: 0x00036520
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 861800, RefRangeEnd = 861806, XrefRangeStart = 861785, XrefRangeEnd = 861800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00038354 File Offset: 0x00036554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861806, XrefRangeEnd = 861854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Command GetRewindCommandAndClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr_GetRewindCommandAndClear_Public_Command_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00038394 File Offset: 0x00036594
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void log(string format, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr_log_Private_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000383F8 File Offset: 0x000365F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861854, XrefRangeEnd = 861858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void log(LogType type, string format, [Optional] Il2CppReferenceArray<global::Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<global::Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr_log_Private_Void_LogType_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00038468 File Offset: 0x00036668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861858, XrefRangeEnd = 861866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrescienceAuthority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00005507 File Offset: 0x00003707
		public void log(string format, params global::Il2CppSystem.Object[] args)
		{
			this.log(format, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00005516 File Offset: 0x00003716
		public void log(LogType type, string format, params global::Il2CppSystem.Object[] args)
		{
			this.log(type, format, new Il2CppReferenceArray<global::Il2CppSystem.Object>(args));
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00005526 File Offset: 0x00003726
		public PrescienceAuthority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x000384A4 File Offset: 0x000366A4
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x0000552F File Offset: 0x0000372F
		public unsafe bool logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.NativeFieldInfoPtr_logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.NativeFieldInfoPtr_logging)) = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x000384CC File Offset: 0x000366CC
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x0000554A File Offset: 0x0000374A
		public unsafe List<IPrediction> predictions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.NativeFieldInfoPtr_predictions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPrediction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.NativeFieldInfoPtr_predictions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr_logging;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr_predictions;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_Logging_Public_get_Boolean_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_set_Logging_Public_set_Void_Boolean_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_IPrediction_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_GetRewindCommandAndClear_Public_Command_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_log_Private_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_log_Private_Void_LogType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000285 RID: 645
		public class UntilPredictionCompleted : Command
		{
			// Token: 0x06001F15 RID: 7957 RVA: 0x0008DA90 File Offset: 0x0008BC90
			// Note: this type is marked as 'beforefieldinit'.
			static UntilPredictionCompleted()
			{
				Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, "UntilPredictionCompleted");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr);
				PrescienceAuthority.UntilPredictionCompleted.NativeFieldInfoPtr_prediction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr, "prediction");
				PrescienceAuthority.UntilPredictionCompleted.NativeMethodInfoPtr__ctor_Public_Void_IPrediction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr, 100664617);
				PrescienceAuthority.UntilPredictionCompleted.NativeMethodInfoPtr_Create_Public_Static_UntilPredictionCompleted_IPrediction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr, 100664618);
				PrescienceAuthority.UntilPredictionCompleted.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr, 100664619);
			}

			// Token: 0x06001F16 RID: 7958 RVA: 0x0008DB0C File Offset: 0x0008BD0C
			[CallerCount(37)]
			[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UntilPredictionCompleted(IPrediction prediction)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prediction);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted.NativeMethodInfoPtr__ctor_Public_Void_IPrediction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F17 RID: 7959 RVA: 0x0008DB58 File Offset: 0x0008BD58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861764, XrefRangeEnd = 861769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PrescienceAuthority.UntilPredictionCompleted Create(IPrediction prediction)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prediction);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted.NativeMethodInfoPtr_Create_Public_Static_UntilPredictionCompleted_IPrediction_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrescienceAuthority.UntilPredictionCompleted>(intPtr3) : null;
				}
			}

			// Token: 0x06001F18 RID: 7960 RVA: 0x0008DB9C File Offset: 0x0008BD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861769, XrefRangeEnd = 861774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrescienceAuthority.UntilPredictionCompleted.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F19 RID: 7961 RVA: 0x0000D3D6 File Offset: 0x0000B5D6
			public UntilPredictionCompleted(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0008DBE8 File Offset: 0x0008BDE8
			// (set) Token: 0x06001F1B RID: 7963 RVA: 0x0000D3DF File Offset: 0x0000B5DF
			public unsafe IPrediction prediction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted.NativeFieldInfoPtr_prediction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrediction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted.NativeFieldInfoPtr_prediction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015D9 RID: 5593
			private static readonly IntPtr NativeFieldInfoPtr_prediction;

			// Token: 0x040015DA RID: 5594
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPrediction_0;

			// Token: 0x040015DB RID: 5595
			private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_UntilPredictionCompleted_IPrediction_0;

			// Token: 0x040015DC RID: 5596
			private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

			// Token: 0x020003B4 RID: 948
			[ObfuscatedName("match.prediction.PrescienceAuthority+UntilPredictionCompleted+<execute>d__3")]
			public sealed class _execute_d__3 : global::Il2CppSystem.Object
			{
				// Token: 0x060029C1 RID: 10689 RVA: 0x000AE6FC File Offset: 0x000AC8FC
				// Note: this type is marked as 'beforefieldinit'.
				static _execute_d__3()
				{
					Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted>.NativeClassPtr, "<execute>d__3");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr);
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, "<>1__state");
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, "<>2__current");
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, "<>4__this");
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, 100664620);
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, 100664621);
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, 100664622);
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, 100664623);
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, 100664624);
					PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr, 100664625);
				}

				// Token: 0x060029C2 RID: 10690 RVA: 0x000AE7DC File Offset: 0x000AC9DC
				[CallerCount(73)]
				[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _execute_d__3(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrescienceAuthority.UntilPredictionCompleted._execute_d__3>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060029C3 RID: 10691 RVA: 0x000AE824 File Offset: 0x000ACA24
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060029C4 RID: 10692 RVA: 0x000AE858 File Offset: 0x000ACA58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861755, XrefRangeEnd = 861759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000BDA RID: 3034
				// (get) Token: 0x060029C5 RID: 10693 RVA: 0x000AE894 File Offset: 0x000ACA94
				public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029C6 RID: 10694 RVA: 0x000AE8D4 File Offset: 0x000ACAD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861759, XrefRangeEnd = 861764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000BDB RID: 3035
				// (get) Token: 0x060029C7 RID: 10695 RVA: 0x000AE908 File Offset: 0x000ACB08
				public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060029C8 RID: 10696 RVA: 0x00013119 File Offset: 0x00011319
				public _execute_d__3(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000BD7 RID: 3031
				// (get) Token: 0x060029C9 RID: 10697 RVA: 0x000AE948 File Offset: 0x000ACB48
				// (set) Token: 0x060029CA RID: 10698 RVA: 0x00013122 File Offset: 0x00011322
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000BD8 RID: 3032
				// (get) Token: 0x060029CB RID: 10699 RVA: 0x000AE970 File Offset: 0x000ACB70
				// (set) Token: 0x060029CC RID: 10700 RVA: 0x0001313D File Offset: 0x0001133D
				public unsafe global::Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000BD9 RID: 3033
				// (get) Token: 0x060029CD RID: 10701 RVA: 0x000AE9A0 File Offset: 0x000ACBA0
				// (set) Token: 0x060029CE RID: 10702 RVA: 0x0001315C File Offset: 0x0001135C
				public unsafe PrescienceAuthority.UntilPredictionCompleted __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrescienceAuthority.UntilPredictionCompleted>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PrescienceAuthority.UntilPredictionCompleted._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04001C28 RID: 7208
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04001C29 RID: 7209
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04001C2A RID: 7210
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04001C2B RID: 7211
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04001C2C RID: 7212
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C2D RID: 7213
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04001C2E RID: 7214
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04001C2F RID: 7215
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04001C30 RID: 7216
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000286 RID: 646
		[ObfuscatedName("match.prediction.PrescienceAuthority+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06001F1C RID: 7964 RVA: 0x0008DC18 File Offset: 0x0008BE18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PrescienceAuthority.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrescienceAuthority>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrescienceAuthority.__c>.NativeClassPtr);
				PrescienceAuthority.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority.__c>.NativeClassPtr, "<>9");
				PrescienceAuthority.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrescienceAuthority.__c>.NativeClassPtr, "<>9__7_0");
				PrescienceAuthority.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.__c>.NativeClassPtr, 100664627);
				PrescienceAuthority.__c.NativeMethodInfoPtr__GetRewindCommandAndClear_b__7_0_Internal_Command_IPrediction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrescienceAuthority.__c>.NativeClassPtr, 100664628);
			}

			// Token: 0x06001F1D RID: 7965 RVA: 0x0008DC94 File Offset: 0x0008BE94
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrescienceAuthority.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F1E RID: 7966 RVA: 0x0008DCD0 File Offset: 0x0008BED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 861774, XrefRangeEnd = 861779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Command _GetRewindCommandAndClear_b__7_0(IPrediction p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrescienceAuthority.__c.NativeMethodInfoPtr__GetRewindCommandAndClear_b__7_0_Internal_Command_IPrediction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
				}
			}

			// Token: 0x06001F1F RID: 7967 RVA: 0x0000D3FE File Offset: 0x0000B5FE
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06001F20 RID: 7968 RVA: 0x0008DD20 File Offset: 0x0008BF20
			// (set) Token: 0x06001F21 RID: 7969 RVA: 0x0000D407 File Offset: 0x0000B607
			public unsafe static PrescienceAuthority.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrescienceAuthority.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrescienceAuthority.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrescienceAuthority.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000888 RID: 2184
			// (get) Token: 0x06001F22 RID: 7970 RVA: 0x0008DD48 File Offset: 0x0008BF48
			// (set) Token: 0x06001F23 RID: 7971 RVA: 0x0000D419 File Offset: 0x0000B619
			public unsafe static Func<IPrediction, Command> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PrescienceAuthority.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IPrediction, Command>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PrescienceAuthority.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015DD RID: 5597
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015DE RID: 5598
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040015DF RID: 5599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015E0 RID: 5600
			private static readonly IntPtr NativeMethodInfoPtr__GetRewindCommandAndClear_b__7_0_Internal_Command_IPrediction_0;
		}
	}
}
