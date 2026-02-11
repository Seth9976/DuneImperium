using System;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace dwd.canis
{
	// Token: 0x02000048 RID: 72
	public class FetchPlayerReputation : Command
	{
		// Token: 0x060002C7 RID: 711 RVA: 0x00026568 File Offset: 0x00024768
		// Note: this type is marked as 'beforefieldinit'.
		static FetchPlayerReputation()
		{
			Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis", "FetchPlayerReputation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr);
			FetchPlayerReputation.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr, "Result");
			FetchPlayerReputation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr, 100663736);
			FetchPlayerReputation.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr, 100663737);
			FetchPlayerReputation.NativeMethodInfoPtr__execute_b__2_1_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr, 100663738);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000265E8 File Offset: 0x000247E8
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FetchPlayerReputation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00026624 File Offset: 0x00024824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499147, XrefRangeEnd = 499152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FetchPlayerReputation.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00026670 File Offset: 0x00024870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499152, XrefRangeEnd = 499161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__2_1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation.NativeMethodInfoPtr__execute_b__2_1_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003370 File Offset: 0x00001570
		public FetchPlayerReputation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000266B4 File Offset: 0x000248B4
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00003379 File Offset: 0x00001579
		public unsafe Dictionary<string, string> Result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation.NativeFieldInfoPtr_Result);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation.NativeFieldInfoPtr_Result), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_Result;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_1_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x020002E4 RID: 740
		[ObfuscatedName("dwd.canis.FetchPlayerReputation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060022D4 RID: 8916 RVA: 0x00090ABC File Offset: 0x0008ECBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr);
				FetchPlayerReputation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr, "<>9");
				FetchPlayerReputation.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr, "<>9__2_0");
				FetchPlayerReputation.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr, "<>9__2_2");
				FetchPlayerReputation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr, 100663740);
				FetchPlayerReputation.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr, 100663741);
				FetchPlayerReputation.__c.NativeMethodInfoPtr__execute_b__2_2_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr, 100663742);
			}

			// Token: 0x060022D5 RID: 8917 RVA: 0x00090B60 File Offset: 0x0008ED60
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchPlayerReputation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022D6 RID: 8918 RVA: 0x00090B9C File Offset: 0x0008ED9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499029, XrefRangeEnd = 499037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__2_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022D7 RID: 8919 RVA: 0x00090BE0 File Offset: 0x0008EDE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499037, XrefRangeEnd = 499047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__2_2(ErrorInfo requestStatus)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(requestStatus));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation.__c.NativeMethodInfoPtr__execute_b__2_2_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022D8 RID: 8920 RVA: 0x00012264 File Offset: 0x00010464
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000966 RID: 2406
			// (get) Token: 0x060022D9 RID: 8921 RVA: 0x00090C28 File Offset: 0x0008EE28
			// (set) Token: 0x060022DA RID: 8922 RVA: 0x0001226D File Offset: 0x0001046D
			public unsafe static FetchPlayerReputation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FetchPlayerReputation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchPlayerReputation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FetchPlayerReputation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x060022DB RID: 8923 RVA: 0x00090C50 File Offset: 0x0008EE50
			// (set) Token: 0x060022DC RID: 8924 RVA: 0x0001227F File Offset: 0x0001047F
			public unsafe static Action<UnityWebRequest> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FetchPlayerReputation.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FetchPlayerReputation.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x060022DD RID: 8925 RVA: 0x00090C78 File Offset: 0x0008EE78
			// (set) Token: 0x060022DE RID: 8926 RVA: 0x00012291 File Offset: 0x00010491
			public unsafe static Action<ErrorInfo> __9__2_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FetchPlayerReputation.__c.NativeFieldInfoPtr___9__2_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FetchPlayerReputation.__c.NativeFieldInfoPtr___9__2_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015E6 RID: 5606
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015E7 RID: 5607
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040015E8 RID: 5608
			private static readonly IntPtr NativeFieldInfoPtr___9__2_2;

			// Token: 0x040015E9 RID: 5609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015EA RID: 5610
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x040015EB RID: 5611
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_2_Internal_Void_ErrorInfo_0;
		}

		// Token: 0x020002E5 RID: 741
		[ObfuscatedName("dwd.canis.FetchPlayerReputation+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x060022DF RID: 8927 RVA: 0x00090CA0 File Offset: 0x0008EEA0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FetchPlayerReputation>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr);
				FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, "<>1__state");
				FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, "<>2__current");
				FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, "<>4__this");
				FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr__url_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, "<url>5__2");
				FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr__requestCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, "<requestCommand>5__3");
				FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, 100663743);
				FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, 100663744);
				FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, 100663745);
				FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, 100663746);
				FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, 100663747);
				FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr, 100663748);
			}

			// Token: 0x060022E0 RID: 8928 RVA: 0x00090DA8 File Offset: 0x0008EFA8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchPlayerReputation._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060022E1 RID: 8929 RVA: 0x00090DF0 File Offset: 0x0008EFF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060022E2 RID: 8930 RVA: 0x00090E24 File Offset: 0x0008F024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499047, XrefRangeEnd = 499142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x060022E3 RID: 8931 RVA: 0x00090E60 File Offset: 0x0008F060
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022E4 RID: 8932 RVA: 0x00090EA0 File Offset: 0x0008F0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 499142, XrefRangeEnd = 499147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x060022E5 RID: 8933 RVA: 0x00090ED4 File Offset: 0x0008F0D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchPlayerReputation._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060022E6 RID: 8934 RVA: 0x000122A3 File Offset: 0x000104A3
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x060022E7 RID: 8935 RVA: 0x00090F14 File Offset: 0x0008F114
			// (set) Token: 0x060022E8 RID: 8936 RVA: 0x000122AC File Offset: 0x000104AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x060022E9 RID: 8937 RVA: 0x00090F3C File Offset: 0x0008F13C
			// (set) Token: 0x060022EA RID: 8938 RVA: 0x000122C7 File Offset: 0x000104C7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x060022EB RID: 8939 RVA: 0x00090F6C File Offset: 0x0008F16C
			// (set) Token: 0x060022EC RID: 8940 RVA: 0x000122E6 File Offset: 0x000104E6
			public unsafe FetchPlayerReputation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchPlayerReputation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x060022ED RID: 8941 RVA: 0x00090F9C File Offset: 0x0008F19C
			// (set) Token: 0x060022EE RID: 8942 RVA: 0x00012305 File Offset: 0x00010505
			public unsafe string _url_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr__url_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr__url_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x060022EF RID: 8943 RVA: 0x00090FC4 File Offset: 0x0008F1C4
			// (set) Token: 0x060022F0 RID: 8944 RVA: 0x00012324 File Offset: 0x00010524
			public unsafe DwdWebRequestCommand _requestCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr__requestCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchPlayerReputation._execute_d__2.NativeFieldInfoPtr__requestCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015EC RID: 5612
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015ED RID: 5613
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015EE RID: 5614
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015EF RID: 5615
			private static readonly IntPtr NativeFieldInfoPtr__url_5__2;

			// Token: 0x040015F0 RID: 5616
			private static readonly IntPtr NativeFieldInfoPtr__requestCommand_5__3;

			// Token: 0x040015F1 RID: 5617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015F2 RID: 5618
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015F3 RID: 5619
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015F4 RID: 5620
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015F5 RID: 5621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015F6 RID: 5622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
