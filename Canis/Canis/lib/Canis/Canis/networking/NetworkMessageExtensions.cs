using System;
using Canis;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace lib.canis.Canis.networking
{
	// Token: 0x0200001C RID: 28
	public static class NetworkMessageExtensions : Object
	{
		// Token: 0x0600010A RID: 266 RVA: 0x0001D29C File Offset: 0x0001B49C
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkMessageExtensions()
		{
			Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "lib.canis.Canis.networking", "NetworkMessageExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr);
			NetworkMessageExtensions.NativeMethodInfoPtr_ToContextualString_Public_Static_String_TargetResponse_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr, 100663452);
			NetworkMessageExtensions.NativeMethodInfoPtr_ToEntityString_Public_Static_String_EntityListTargetResponse_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr, 100663453);
			NetworkMessageExtensions.NativeMethodInfoPtr_ToContextualString_Public_Static_String_SelectionMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr, 100663454);
			NetworkMessageExtensions.NativeMethodInfoPtr_ToEntityString_Public_Static_String_SelectionWithTargetsRequired_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr, 100663455);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0001D31C File Offset: 0x0001B51C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 544046, RefRangeEnd = 544048, XrefRangeStart = 544041, XrefRangeEnd = 544046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToContextualString(this TargetResponse tr, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.NativeMethodInfoPtr_ToContextualString_Public_Static_String_TargetResponse_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0001D36C File Offset: 0x0001B56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544048, XrefRangeEnd = 544074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToEntityString(this EntityListTargetResponse eltr, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eltr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.NativeMethodInfoPtr_ToEntityString_Public_Static_String_EntityListTargetResponse_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0001D3BC File Offset: 0x0001B5BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 544106, RefRangeEnd = 544108, XrefRangeStart = 544074, XrefRangeEnd = 544106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToContextualString(this SelectionMessage sm, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sm);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.NativeMethodInfoPtr_ToContextualString_Public_Static_String_SelectionMessage_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0001D40C File Offset: 0x0001B60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544108, XrefRangeEnd = 544137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToEntityString(this SelectionWithTargetsRequired selection, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.NativeMethodInfoPtr_ToEntityString_Public_Static_String_SelectionWithTargetsRequired_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002880 File Offset: 0x00000A80
		public NetworkMessageExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_ToContextualString_Public_Static_String_TargetResponse_Match_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_ToEntityString_Public_Static_String_EntityListTargetResponse_Match_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_ToContextualString_Public_Static_String_SelectionMessage_Match_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_ToEntityString_Public_Static_String_SelectionWithTargetsRequired_Match_0;

		// Token: 0x02000242 RID: 578
		[ObfuscatedName("lib.canis.Canis.networking.NetworkMessageExtensions+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06001861 RID: 6241 RVA: 0x0007A484 File Offset: 0x00078684
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass1_0>.NativeClassPtr);
				NetworkMessageExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass1_0>.NativeClassPtr, "match");
				NetworkMessageExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663456);
				NetworkMessageExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ToEntityString_b__0_Internal_String_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass1_0>.NativeClassPtr, 100663457);
			}

			// Token: 0x06001862 RID: 6242 RVA: 0x0007A4EC File Offset: 0x000786EC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001863 RID: 6243 RVA: 0x0007A528 File Offset: 0x00078728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543993, XrefRangeEnd = 543996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToEntityString_b__0(EntityID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.__c__DisplayClass1_0.NativeMethodInfoPtr__ToEntityString_b__0_Internal_String_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001864 RID: 6244 RVA: 0x0000BAB3 File Offset: 0x00009CB3
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000558 RID: 1368
			// (get) Token: 0x06001865 RID: 6245 RVA: 0x0007A570 File Offset: 0x00078770
			// (set) Token: 0x06001866 RID: 6246 RVA: 0x0000BABC File Offset: 0x00009CBC
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkMessageExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkMessageExtensions.__c__DisplayClass1_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F9B RID: 3995
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04000F9C RID: 3996
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000F9D RID: 3997
			private static readonly IntPtr NativeMethodInfoPtr__ToEntityString_b__0_Internal_String_EntityID_0;
		}

		// Token: 0x02000243 RID: 579
		[ObfuscatedName("lib.canis.Canis.networking.NetworkMessageExtensions+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06001867 RID: 6247 RVA: 0x0007A5A0 File Offset: 0x000787A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkMessageExtensions>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr);
				NetworkMessageExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr, "match");
				NetworkMessageExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr, "<>9__1");
				NetworkMessageExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663458);
				NetworkMessageExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ToEntityString_b__0_Internal_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663459);
				NetworkMessageExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ToEntityString_b__1_Internal_String_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr, 100663460);
			}

			// Token: 0x06001868 RID: 6248 RVA: 0x0007A630 File Offset: 0x00078830
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkMessageExtensions.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001869 RID: 6249 RVA: 0x0007A66C File Offset: 0x0007886C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 543996, XrefRangeEnd = 544036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToEntityString_b__0(KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>> tuple)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tuple));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ToEntityString_b__0_Internal_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600186A RID: 6250 RVA: 0x0007A6BC File Offset: 0x000788BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544036, XrefRangeEnd = 544041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _ToEntityString_b__1(TargetInformation ti)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ti);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageExtensions.__c__DisplayClass3_0.NativeMethodInfoPtr__ToEntityString_b__1_Internal_String_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600186B RID: 6251 RVA: 0x0000BADB File Offset: 0x00009CDB
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000559 RID: 1369
			// (get) Token: 0x0600186C RID: 6252 RVA: 0x0007A704 File Offset: 0x00078904
			// (set) Token: 0x0600186D RID: 6253 RVA: 0x0000BAE4 File Offset: 0x00009CE4
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkMessageExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkMessageExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700055A RID: 1370
			// (get) Token: 0x0600186E RID: 6254 RVA: 0x0007A734 File Offset: 0x00078934
			// (set) Token: 0x0600186F RID: 6255 RVA: 0x0000BB03 File Offset: 0x00009D03
			public unsafe Func<TargetInformation, string> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkMessageExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkMessageExtensions.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F9E RID: 3998
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04000F9F RID: 3999
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04000FA0 RID: 4000
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000FA1 RID: 4001
			private static readonly IntPtr NativeMethodInfoPtr__ToEntityString_b__0_Internal_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

			// Token: 0x04000FA2 RID: 4002
			private static readonly IntPtr NativeMethodInfoPtr__ToEntityString_b__1_Internal_String_TargetInformation_0;
		}
	}
}
