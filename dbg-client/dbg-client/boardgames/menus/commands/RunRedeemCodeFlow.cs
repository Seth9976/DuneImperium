using System;
using boardgames.menus.prompts;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.menus.commands
{
	// Token: 0x02000232 RID: 562
	public class RunRedeemCodeFlow : Command
	{
		// Token: 0x06001989 RID: 6537 RVA: 0x00070970 File Offset: 0x0006EB70
		// Note: this type is marked as 'beforefieldinit'.
		static RunRedeemCodeFlow()
		{
			Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunRedeemCodeFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr);
			RunRedeemCodeFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr, 100667273);
			RunRedeemCodeFlow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr, 100667274);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000709C8 File Offset: 0x0006EBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529824, XrefRangeEnd = 529828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunRedeemCodeFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00070A14 File Offset: 0x0006EC14
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunRedeemCodeFlow()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x0000E05F File Offset: 0x0000C25F
		public RunRedeemCodeFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000416 RID: 1046
		public class RedeemCodeResponse : Object
		{
			// Token: 0x06003171 RID: 12657 RVA: 0x000BC118 File Offset: 0x000BA318
			// Note: this type is marked as 'beforefieldinit'.
			static RedeemCodeResponse()
			{
				Il2CppClassPointerStore<RunRedeemCodeFlow.RedeemCodeResponse>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr, "RedeemCodeResponse");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRedeemCodeFlow.RedeemCodeResponse>.NativeClassPtr);
				RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_success = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.RedeemCodeResponse>.NativeClassPtr, "success");
				RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_productIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.RedeemCodeResponse>.NativeClassPtr, "productIds");
				RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.RedeemCodeResponse>.NativeClassPtr, "msg");
				RunRedeemCodeFlow.RedeemCodeResponse.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow.RedeemCodeResponse>.NativeClassPtr, 100667275);
			}

			// Token: 0x06003172 RID: 12658 RVA: 0x000BC194 File Offset: 0x000BA394
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RedeemCodeResponse()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRedeemCodeFlow.RedeemCodeResponse>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow.RedeemCodeResponse.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003173 RID: 12659 RVA: 0x00019900 File Offset: 0x00017B00
			public RedeemCodeResponse(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E58 RID: 3672
			// (get) Token: 0x06003174 RID: 12660 RVA: 0x000BC1D0 File Offset: 0x000BA3D0
			// (set) Token: 0x06003175 RID: 12661 RVA: 0x00019909 File Offset: 0x00017B09
			public unsafe bool success
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_success);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_success)) = value;
				}
			}

			// Token: 0x17000E59 RID: 3673
			// (get) Token: 0x06003176 RID: 12662 RVA: 0x000BC1F8 File Offset: 0x000BA3F8
			// (set) Token: 0x06003177 RID: 12663 RVA: 0x00019924 File Offset: 0x00017B24
			public unsafe Il2CppStringArray productIds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_productIds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_productIds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E5A RID: 3674
			// (get) Token: 0x06003178 RID: 12664 RVA: 0x000BC228 File Offset: 0x000BA428
			// (set) Token: 0x06003179 RID: 12665 RVA: 0x00019943 File Offset: 0x00017B43
			public unsafe string msg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_msg);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.RedeemCodeResponse.NativeFieldInfoPtr_msg), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001E8F RID: 7823
			private static readonly IntPtr NativeFieldInfoPtr_success;

			// Token: 0x04001E90 RID: 7824
			private static readonly IntPtr NativeFieldInfoPtr_productIds;

			// Token: 0x04001E91 RID: 7825
			private static readonly IntPtr NativeFieldInfoPtr_msg;

			// Token: 0x04001E92 RID: 7826
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000417 RID: 1047
		[ObfuscatedName("boardgames.menus.commands.RunRedeemCodeFlow+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600317A RID: 12666 RVA: 0x000BC250 File Offset: 0x000BA450
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunRedeemCodeFlow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRedeemCodeFlow.__c>.NativeClassPtr);
				RunRedeemCodeFlow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.__c>.NativeClassPtr, "<>9");
				RunRedeemCodeFlow.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.__c>.NativeClassPtr, "<>9__1_0");
				RunRedeemCodeFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow.__c>.NativeClassPtr, 100667277);
				RunRedeemCodeFlow.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow.__c>.NativeClassPtr, 100667278);
			}

			// Token: 0x0600317B RID: 12667 RVA: 0x000BC2CC File Offset: 0x000BA4CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRedeemCodeFlow.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600317C RID: 12668 RVA: 0x000BC308 File Offset: 0x000BA508
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529688, XrefRangeEnd = 529696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow.__c.NativeMethodInfoPtr__execute_b__1_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600317D RID: 12669 RVA: 0x00019962 File Offset: 0x00017B62
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E5B RID: 3675
			// (get) Token: 0x0600317E RID: 12670 RVA: 0x000BC34C File Offset: 0x000BA54C
			// (set) Token: 0x0600317F RID: 12671 RVA: 0x0001996B File Offset: 0x00017B6B
			public unsafe static RunRedeemCodeFlow.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunRedeemCodeFlow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRedeemCodeFlow.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunRedeemCodeFlow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E5C RID: 3676
			// (get) Token: 0x06003180 RID: 12672 RVA: 0x000BC374 File Offset: 0x000BA574
			// (set) Token: 0x06003181 RID: 12673 RVA: 0x0001997D File Offset: 0x00017B7D
			public unsafe static Action<UnityWebRequest> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunRedeemCodeFlow.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunRedeemCodeFlow.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E93 RID: 7827
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001E94 RID: 7828
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001E95 RID: 7829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E96 RID: 7830
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000418 RID: 1048
		[ObfuscatedName("boardgames.menus.commands.RunRedeemCodeFlow+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06003182 RID: 12674 RVA: 0x000BC39C File Offset: 0x000BA59C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr);
				RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_response = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr, "response");
				RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_responseMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr, "responseMsg");
				RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_productIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr, "productIDs");
				RunRedeemCodeFlow.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr, 100667279);
				RunRedeemCodeFlow.__c__DisplayClass1_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr, 100667280);
			}

			// Token: 0x06003183 RID: 12675 RVA: 0x000BC42C File Offset: 0x000BA62C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRedeemCodeFlow.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003184 RID: 12676 RVA: 0x000BC468 File Offset: 0x000BA668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529696, XrefRangeEnd = 529708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1(DwdWebRequestCommand request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003185 RID: 12677 RVA: 0x0001998F File Offset: 0x00017B8F
			public __c__DisplayClass1_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E5D RID: 3677
			// (get) Token: 0x06003186 RID: 12678 RVA: 0x000BC4AC File Offset: 0x000BA6AC
			// (set) Token: 0x06003187 RID: 12679 RVA: 0x00019998 File Offset: 0x00017B98
			public unsafe bool response
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_response);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_response)) = value;
				}
			}

			// Token: 0x17000E5E RID: 3678
			// (get) Token: 0x06003188 RID: 12680 RVA: 0x000BC4D4 File Offset: 0x000BA6D4
			// (set) Token: 0x06003189 RID: 12681 RVA: 0x000199B3 File Offset: 0x00017BB3
			public unsafe string responseMsg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_responseMsg);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_responseMsg), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000E5F RID: 3679
			// (get) Token: 0x0600318A RID: 12682 RVA: 0x000BC4FC File Offset: 0x000BA6FC
			// (set) Token: 0x0600318B RID: 12683 RVA: 0x000199D2 File Offset: 0x00017BD2
			public unsafe Il2CppStringArray productIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_productIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow.__c__DisplayClass1_0.NativeFieldInfoPtr_productIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E97 RID: 7831
			private static readonly IntPtr NativeFieldInfoPtr_response;

			// Token: 0x04001E98 RID: 7832
			private static readonly IntPtr NativeFieldInfoPtr_responseMsg;

			// Token: 0x04001E99 RID: 7833
			private static readonly IntPtr NativeFieldInfoPtr_productIDs;

			// Token: 0x04001E9A RID: 7834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001E9B RID: 7835
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0;
		}

		// Token: 0x02000419 RID: 1049
		[ObfuscatedName("boardgames.menus.commands.RunRedeemCodeFlow+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x0600318C RID: 12684 RVA: 0x000BC52C File Offset: 0x000BA72C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRedeemCodeFlow>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr);
				RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, "<>1__state");
				RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, "<>2__current");
				RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, "<>8__1");
				RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr__redeemPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, "<redeemPrompt>5__2");
				RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr__loginPromptFlow_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, "<loginPromptFlow>5__3");
				RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, 100667281);
				RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, 100667282);
				RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, 100667283);
				RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, 100667284);
				RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, 100667285);
				RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr, 100667286);
			}

			// Token: 0x0600318D RID: 12685 RVA: 0x000BC634 File Offset: 0x000BA834
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRedeemCodeFlow._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600318E RID: 12686 RVA: 0x000BC67C File Offset: 0x000BA87C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600318F RID: 12687 RVA: 0x000BC6B0 File Offset: 0x000BA8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529708, XrefRangeEnd = 529819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000E65 RID: 3685
			// (get) Token: 0x06003190 RID: 12688 RVA: 0x000BC6EC File Offset: 0x000BA8EC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003191 RID: 12689 RVA: 0x000BC72C File Offset: 0x000BA92C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 529819, XrefRangeEnd = 529824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000E66 RID: 3686
			// (get) Token: 0x06003192 RID: 12690 RVA: 0x000BC760 File Offset: 0x000BA960
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRedeemCodeFlow._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003193 RID: 12691 RVA: 0x000199F1 File Offset: 0x00017BF1
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000E60 RID: 3680
			// (get) Token: 0x06003194 RID: 12692 RVA: 0x000BC7A0 File Offset: 0x000BA9A0
			// (set) Token: 0x06003195 RID: 12693 RVA: 0x000199FA File Offset: 0x00017BFA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000E61 RID: 3681
			// (get) Token: 0x06003196 RID: 12694 RVA: 0x000BC7C8 File Offset: 0x000BA9C8
			// (set) Token: 0x06003197 RID: 12695 RVA: 0x00019A15 File Offset: 0x00017C15
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E62 RID: 3682
			// (get) Token: 0x06003198 RID: 12696 RVA: 0x000BC7F8 File Offset: 0x000BA9F8
			// (set) Token: 0x06003199 RID: 12697 RVA: 0x00019A34 File Offset: 0x00017C34
			public unsafe RunRedeemCodeFlow.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRedeemCodeFlow.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E63 RID: 3683
			// (get) Token: 0x0600319A RID: 12698 RVA: 0x000BC828 File Offset: 0x000BAA28
			// (set) Token: 0x0600319B RID: 12699 RVA: 0x00019A53 File Offset: 0x00017C53
			public unsafe RedeemPrompt _redeemPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr__redeemPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RedeemPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr__redeemPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000E64 RID: 3684
			// (get) Token: 0x0600319C RID: 12700 RVA: 0x000BC858 File Offset: 0x000BAA58
			// (set) Token: 0x0600319D RID: 12701 RVA: 0x00019A72 File Offset: 0x00017C72
			public unsafe RunLoginPromptFlow _loginPromptFlow_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr__loginPromptFlow_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLoginPromptFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRedeemCodeFlow._execute_d__1.NativeFieldInfoPtr__loginPromptFlow_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001E9C RID: 7836
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001E9D RID: 7837
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001E9E RID: 7838
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001E9F RID: 7839
			private static readonly IntPtr NativeFieldInfoPtr__redeemPrompt_5__2;

			// Token: 0x04001EA0 RID: 7840
			private static readonly IntPtr NativeFieldInfoPtr__loginPromptFlow_5__3;

			// Token: 0x04001EA1 RID: 7841
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001EA2 RID: 7842
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EA3 RID: 7843
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001EA4 RID: 7844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001EA5 RID: 7845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001EA6 RID: 7846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
