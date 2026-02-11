using System;
using dwd.core.commands;
using dwd.core.platform.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace dwd.core.platform
{
	// Token: 0x02000013 RID: 19
	public class SendInvitationEmail : Command
	{
		// Token: 0x06000109 RID: 265 RVA: 0x000091F0 File Offset: 0x000073F0
		// Note: this type is marked as 'beforefieldinit'.
		static SendInvitationEmail()
		{
			Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform", "SendInvitationEmail");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr);
			SendInvitationEmail.NativeFieldInfoPtr_platformAccountURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, "platformAccountURI");
			SendInvitationEmail.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, "client");
			SendInvitationEmail.NativeFieldInfoPtr_tostring = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, "tostring");
			SendInvitationEmail.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, "locale");
			SendInvitationEmail.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, "status");
			SendInvitationEmail.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, 100663514);
			SendInvitationEmail.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, 100663515);
			SendInvitationEmail.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, 100663516);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000092C0 File Offset: 0x000074C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167208, XrefRangeEnd = 1167218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendInvitationEmail(string platformAccountURI, string client, string tostring, string locale)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platformAccountURI);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(tostring);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00009344 File Offset: 0x00007544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167218, XrefRangeEnd = 1167223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendInvitationEmail.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009390 File Offset: 0x00007590
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002548 File Offset: 0x00000748
		public SendInvitationEmail(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000093C8 File Offset: 0x000075C8
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002551 File Offset: 0x00000751
		public unsafe string platformAccountURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_platformAccountURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_platformAccountURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000093F0 File Offset: 0x000075F0
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002570 File Offset: 0x00000770
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00009418 File Offset: 0x00007618
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000258F File Offset: 0x0000078F
		public unsafe string tostring
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_tostring);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_tostring), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00009440 File Offset: 0x00007640
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000025AE File Offset: 0x000007AE
		public unsafe string locale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_locale);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_locale), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00009468 File Offset: 0x00007668
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000025CD File Offset: 0x000007CD
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_platformAccountURI;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_tostring;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_locale;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x0200006D RID: 109
		public class Body : Object
		{
			// Token: 0x0600043E RID: 1086 RVA: 0x000131C4 File Offset: 0x000113C4
			// Note: this type is marked as 'beforefieldinit'.
			static Body()
			{
				Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, "Body");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr);
				SendInvitationEmail.Body.NativeFieldInfoPtr_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr, "from");
				SendInvitationEmail.Body.NativeFieldInfoPtr_to = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr, "to");
				SendInvitationEmail.Body.NativeFieldInfoPtr_locale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr, "locale");
				SendInvitationEmail.Body.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr, "client");
				SendInvitationEmail.Body.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr, 100663517);
			}

			// Token: 0x0600043F RID: 1087 RVA: 0x00013254 File Offset: 0x00011454
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Body()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendInvitationEmail.Body>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail.Body.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000440 RID: 1088 RVA: 0x00004111 File Offset: 0x00002311
			public Body(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000441 RID: 1089 RVA: 0x00013290 File Offset: 0x00011490
			// (set) Token: 0x06000442 RID: 1090 RVA: 0x0000411A File Offset: 0x0000231A
			public unsafe PlatformToken from
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_from);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformToken>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_from), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x000132C0 File Offset: 0x000114C0
			// (set) Token: 0x06000444 RID: 1092 RVA: 0x00004139 File Offset: 0x00002339
			public unsafe string to
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_to);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_to), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x000132E8 File Offset: 0x000114E8
			// (set) Token: 0x06000446 RID: 1094 RVA: 0x00004158 File Offset: 0x00002358
			public unsafe string locale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_locale);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_locale), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000447 RID: 1095 RVA: 0x00013310 File Offset: 0x00011510
			// (set) Token: 0x06000448 RID: 1096 RVA: 0x00004177 File Offset: 0x00002377
			public unsafe string client
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_client);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail.Body.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040002AA RID: 682
			private static readonly IntPtr NativeFieldInfoPtr_from;

			// Token: 0x040002AB RID: 683
			private static readonly IntPtr NativeFieldInfoPtr_to;

			// Token: 0x040002AC RID: 684
			private static readonly IntPtr NativeFieldInfoPtr_locale;

			// Token: 0x040002AD RID: 685
			private static readonly IntPtr NativeFieldInfoPtr_client;

			// Token: 0x040002AE RID: 686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200006E RID: 110
		[ObfuscatedName("dwd.core.platform.SendInvitationEmail+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06000449 RID: 1097 RVA: 0x00013338 File Offset: 0x00011538
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendInvitationEmail>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr);
				SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, "<>1__state");
				SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, "<>2__current");
				SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, "<>4__this");
				SendInvitationEmail._execute_d__6.NativeFieldInfoPtr__post_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, "<post>5__2");
				SendInvitationEmail._execute_d__6.NativeFieldInfoPtr__send_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, "<send>5__3");
				SendInvitationEmail._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, 100663518);
				SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, 100663519);
				SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, 100663520);
				SendInvitationEmail._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, 100663521);
				SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, 100663522);
				SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, 100663523);
				SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr, 100663524);
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00013454 File Offset: 0x00011654
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendInvitationEmail._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x0001349C File Offset: 0x0001169C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167092, XrefRangeEnd = 1167097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x000134D0 File Offset: 0x000116D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167097, XrefRangeEnd = 1167200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x0001350C File Offset: 0x0001170C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167200, XrefRangeEnd = 1167203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail._execute_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x0600044E RID: 1102 RVA: 0x00013540 File Offset: 0x00011740
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x00013580 File Offset: 0x00011780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167203, XrefRangeEnd = 1167208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000450 RID: 1104 RVA: 0x000135B4 File Offset: 0x000117B4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendInvitationEmail._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x00004196 File Offset: 0x00002396
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000452 RID: 1106 RVA: 0x000135F4 File Offset: 0x000117F4
			// (set) Token: 0x06000453 RID: 1107 RVA: 0x0000419F File Offset: 0x0000239F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x0001361C File Offset: 0x0001181C
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x000041BA File Offset: 0x000023BA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001364C File Offset: 0x0001184C
			// (set) Token: 0x06000457 RID: 1111 RVA: 0x000041D9 File Offset: 0x000023D9
			public unsafe SendInvitationEmail __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendInvitationEmail>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001367C File Offset: 0x0001187C
			// (set) Token: 0x06000459 RID: 1113 RVA: 0x000041F8 File Offset: 0x000023F8
			public unsafe UnityWebRequest _post_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr__post_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr__post_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x0600045A RID: 1114 RVA: 0x000136AC File Offset: 0x000118AC
			// (set) Token: 0x0600045B RID: 1115 RVA: 0x00004217 File Offset: 0x00002417
			public unsafe UnityWebRequestAsyncOperation _send_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr__send_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequestAsyncOperation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendInvitationEmail._execute_d__6.NativeFieldInfoPtr__send_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002AF RID: 687
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040002B0 RID: 688
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040002B1 RID: 689
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040002B2 RID: 690
			private static readonly IntPtr NativeFieldInfoPtr__post_5__2;

			// Token: 0x040002B3 RID: 691
			private static readonly IntPtr NativeFieldInfoPtr__send_5__3;

			// Token: 0x040002B4 RID: 692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040002B5 RID: 693
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002B6 RID: 694
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040002B7 RID: 695
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040002B8 RID: 696
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040002B9 RID: 697
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040002BA RID: 698
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
