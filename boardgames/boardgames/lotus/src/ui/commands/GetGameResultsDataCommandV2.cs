using System;
using boardgames.ui.commands;
using Canis.utils.ids;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace lotus.src.ui.commands
{
	// Token: 0x020000EF RID: 239
	public class GetGameResultsDataCommandV2 : IGetGameResultsDataCommand
	{
		// Token: 0x06000B8F RID: 2959 RVA: 0x00035FA8 File Offset: 0x000341A8
		// Note: this type is marked as 'beforefieldinit'.
		static GetGameResultsDataCommandV2()
		{
			Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.ui.commands", "GetGameResultsDataCommandV2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr);
			GetGameResultsDataCommandV2.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, "gameID");
			GetGameResultsDataCommandV2.NativeFieldInfoPtr_usedFailback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, "usedFailback");
			GetGameResultsDataCommandV2.NativeFieldInfoPtr_BOMChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, "BOMChar");
			GetGameResultsDataCommandV2.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, 100665146);
			GetGameResultsDataCommandV2.NativeMethodInfoPtr_DeflateDecompress_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, 100665147);
			GetGameResultsDataCommandV2.NativeMethodInfoPtr_FixBOMIfNeeded_Private_Static_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, 100665148);
			GetGameResultsDataCommandV2.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, 100665149);
			GetGameResultsDataCommandV2.NativeMethodInfoPtr_GetResults_Public_Virtual_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, 100665150);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00036078 File Offset: 0x00034278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994811, RefRangeEnd = 994813, XrefRangeStart = 994811, XrefRangeEnd = 994813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetGameResultsDataCommandV2(GameID gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000360C4 File Offset: 0x000342C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994899, XrefRangeEnd = 994925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> DeflateDecompress(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2.NativeMethodInfoPtr_DeflateDecompress_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00036114 File Offset: 0x00034314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994925, XrefRangeEnd = 994929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool FixBOMIfNeeded(ref string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(str);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2.NativeMethodInfoPtr_FixBOMIfNeeded_Private_Static_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				str = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00036164 File Offset: 0x00034364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994929, XrefRangeEnd = 994934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetGameResultsDataCommandV2.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000361B0 File Offset: 0x000343B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994934, XrefRangeEnd = 994947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DBGGameResults GetResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetGameResultsDataCommandV2.NativeMethodInfoPtr_GetResults_Public_Virtual_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr3) : null;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000743E File Offset: 0x0000563E
		public GetGameResultsDataCommandV2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000361FC File Offset: 0x000343FC
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x00007447 File Offset: 0x00005647
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0003622C File Offset: 0x0003442C
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x00007466 File Offset: 0x00005666
		public unsafe bool usedFailback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2.NativeFieldInfoPtr_usedFailback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2.NativeFieldInfoPtr_usedFailback)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x00036254 File Offset: 0x00034454
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x00007481 File Offset: 0x00005681
		public unsafe static char BOMChar
		{
			get
			{
				char c;
				IL2CPP.il2cpp_field_static_get_value(GetGameResultsDataCommandV2.NativeFieldInfoPtr_BOMChar, (void*)(&c));
				return c;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GetGameResultsDataCommandV2.NativeFieldInfoPtr_BOMChar, (void*)(&value));
			}
		}

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_usedFailback;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeFieldInfoPtr_BOMChar;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr_DeflateDecompress_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeMethodInfoPtr_FixBOMIfNeeded_Private_Static_Boolean_byref_String_0;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_GetResults_Public_Virtual_DBGGameResults_0;

		// Token: 0x02000246 RID: 582
		[ObfuscatedName("lotus.src.ui.commands.GetGameResultsDataCommandV2+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AEF RID: 6895 RVA: 0x00064400 File Offset: 0x00062600
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GetGameResultsDataCommandV2.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameResultsDataCommandV2.__c>.NativeClassPtr);
				GetGameResultsDataCommandV2.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2.__c>.NativeClassPtr, "<>9");
				GetGameResultsDataCommandV2.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2.__c>.NativeClassPtr, "<>9__6_0");
				GetGameResultsDataCommandV2.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2.__c>.NativeClassPtr, 100665152);
				GetGameResultsDataCommandV2.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2.__c>.NativeClassPtr, 100665153);
			}

			// Token: 0x06001AF0 RID: 6896 RVA: 0x0006447C File Offset: 0x0006267C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameResultsDataCommandV2.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AF1 RID: 6897 RVA: 0x000644B8 File Offset: 0x000626B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994825, XrefRangeEnd = 994833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__6_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2.__c.NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AF2 RID: 6898 RVA: 0x0000EA2E File Offset: 0x0000CC2E
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E8 RID: 2024
			// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x000644FC File Offset: 0x000626FC
			// (set) Token: 0x06001AF4 RID: 6900 RVA: 0x0000EA37 File Offset: 0x0000CC37
			public unsafe static GetGameResultsDataCommandV2.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetGameResultsDataCommandV2.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetGameResultsDataCommandV2.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetGameResultsDataCommandV2.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E9 RID: 2025
			// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00064524 File Offset: 0x00062724
			// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x0000EA49 File Offset: 0x0000CC49
			public unsafe static Action<UnityWebRequest> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetGameResultsDataCommandV2.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetGameResultsDataCommandV2.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001048 RID: 4168
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001049 RID: 4169
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x0400104A RID: 4170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400104B RID: 4171
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__6_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000247 RID: 583
		[ObfuscatedName("lotus.src.ui.commands.GetGameResultsDataCommandV2+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06001AF7 RID: 6903 RVA: 0x0006454C File Offset: 0x0006274C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetGameResultsDataCommandV2>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr);
				GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, "<>1__state");
				GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, "<>2__current");
				GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, "<>4__this");
				GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__dwdWebRequestCommand_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, "<dwdWebRequestCommand>5__2");
				GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__dwdSecureWebRequestCommand_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, "<dwdSecureWebRequestCommand>5__3");
				GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__oldGameResults_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, "<oldGameResults>5__4");
				GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, 100665154);
				GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, 100665155);
				GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, 100665156);
				GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, 100665157);
				GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, 100665158);
				GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr, 100665159);
			}

			// Token: 0x06001AF8 RID: 6904 RVA: 0x00064668 File Offset: 0x00062868
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameResultsDataCommandV2._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AF9 RID: 6905 RVA: 0x000646B0 File Offset: 0x000628B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AFA RID: 6906 RVA: 0x000646E4 File Offset: 0x000628E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994833, XrefRangeEnd = 994894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x06001AFB RID: 6907 RVA: 0x00064720 File Offset: 0x00062920
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001AFC RID: 6908 RVA: 0x00064760 File Offset: 0x00062960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994894, XrefRangeEnd = 994899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007F1 RID: 2033
			// (get) Token: 0x06001AFD RID: 6909 RVA: 0x00064794 File Offset: 0x00062994
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommandV2._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001AFE RID: 6910 RVA: 0x0000EA5B File Offset: 0x0000CC5B
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007EA RID: 2026
			// (get) Token: 0x06001AFF RID: 6911 RVA: 0x000647D4 File Offset: 0x000629D4
			// (set) Token: 0x06001B00 RID: 6912 RVA: 0x0000EA64 File Offset: 0x0000CC64
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x06001B01 RID: 6913 RVA: 0x000647FC File Offset: 0x000629FC
			// (set) Token: 0x06001B02 RID: 6914 RVA: 0x0000EA7F File Offset: 0x0000CC7F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x06001B03 RID: 6915 RVA: 0x0006482C File Offset: 0x00062A2C
			// (set) Token: 0x06001B04 RID: 6916 RVA: 0x0000EA9E File Offset: 0x0000CC9E
			public unsafe GetGameResultsDataCommandV2 __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetGameResultsDataCommandV2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0006485C File Offset: 0x00062A5C
			// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000EABD File Offset: 0x0000CCBD
			public unsafe DwdWebRequestCommand _dwdWebRequestCommand_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__dwdWebRequestCommand_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__dwdWebRequestCommand_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0006488C File Offset: 0x00062A8C
			// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000EADC File Offset: 0x0000CCDC
			public unsafe DwdWebRequestCommand _dwdSecureWebRequestCommand_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__dwdSecureWebRequestCommand_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DwdWebRequestCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__dwdSecureWebRequestCommand_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x06001B09 RID: 6921 RVA: 0x000648BC File Offset: 0x00062ABC
			// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0000EAFB File Offset: 0x0000CCFB
			public unsafe GetGameResultsDataCommand _oldGameResults_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__oldGameResults_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetGameResultsDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommandV2._execute_d__6.NativeFieldInfoPtr__oldGameResults_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400104C RID: 4172
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400104D RID: 4173
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400104E RID: 4174
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400104F RID: 4175
			private static readonly IntPtr NativeFieldInfoPtr__dwdWebRequestCommand_5__2;

			// Token: 0x04001050 RID: 4176
			private static readonly IntPtr NativeFieldInfoPtr__dwdSecureWebRequestCommand_5__3;

			// Token: 0x04001051 RID: 4177
			private static readonly IntPtr NativeFieldInfoPtr__oldGameResults_5__4;

			// Token: 0x04001052 RID: 4178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001053 RID: 4179
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001054 RID: 4180
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001055 RID: 4181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001056 RID: 4182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001057 RID: 4183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
