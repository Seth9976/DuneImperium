using System;
using Canis.utils.ids;
using dwd.core;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace platformCore.scoreboard
{
	// Token: 0x02000007 RID: 7
	public class FetchScoreboard : Command
	{
		// Token: 0x0600001E RID: 30 RVA: 0x000037C4 File Offset: 0x000019C4
		// Note: this type is marked as 'beforefieldinit'.
		static FetchScoreboard()
		{
			Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("platformCore.dll", "platformCore.scoreboard", "FetchScoreboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr);
			FetchScoreboard.NativeFieldInfoPtr__Scoreboard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "<Scoreboard>k__BackingField");
			FetchScoreboard.NativeFieldInfoPtr_global = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "global");
			FetchScoreboard.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "top");
			FetchScoreboard.NativeFieldInfoPtr_number = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "number");
			FetchScoreboard.NativeFieldInfoPtr_relativeTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "relativeTo");
			FetchScoreboard.NativeFieldInfoPtr_friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "friends");
			FetchScoreboard.NativeFieldInfoPtr_URL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "URL");
			FetchScoreboard.NativeFieldInfoPtr_Client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "Client");
			FetchScoreboard.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "status");
			FetchScoreboard.NativeMethodInfoPtr_get_Scoreboard_Public_get_Scoreboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, 100663310);
			FetchScoreboard.NativeMethodInfoPtr_set_Scoreboard_Private_set_Void_Scoreboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, 100663311);
			FetchScoreboard.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_AccountID_Il2CppReferenceArray_1_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, 100663312);
			FetchScoreboard.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, 100663313);
			FetchScoreboard.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, 100663314);
			FetchScoreboard.NativeMethodInfoPtr__execute_b__12_0_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, 100663315);
			FetchScoreboard.NativeMethodInfoPtr__execute_b__12_1_Private_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, 100663316);
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00003934 File Offset: 0x00001B34
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00003974 File Offset: 0x00001B74
		public unsafe Scoreboard Scoreboard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard.NativeMethodInfoPtr_get_Scoreboard_Public_get_Scoreboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Scoreboard>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard.NativeMethodInfoPtr_set_Scoreboard_Private_set_Void_Scoreboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000039B8 File Offset: 0x00001BB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1249781, RefRangeEnd = 1249784, XrefRangeStart = 1249771, XrefRangeEnd = 1249781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FetchScoreboard(string url, bool global, int top, int number, AccountID relativeTo, Il2CppReferenceArray<AccountID> friends, string client = "")
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref global;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref number;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeTo);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(friends);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(client);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_AccountID_Il2CppReferenceArray_1_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003A68 File Offset: 0x00001C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249784, XrefRangeEnd = 1249789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FetchScoreboard.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003AB4 File Offset: 0x00001CB4
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003AEC File Offset: 0x00001CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249789, XrefRangeEnd = 1249817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__12_0(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard.NativeMethodInfoPtr__execute_b__12_0_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003B30 File Offset: 0x00001D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249817, XrefRangeEnd = 1249818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__12_1(ErrorInfo _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard.NativeMethodInfoPtr__execute_b__12_1_Private_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000210F File Offset: 0x0000030F
		public FetchScoreboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003B78 File Offset: 0x00001D78
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe Scoreboard _Scoreboard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr__Scoreboard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scoreboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr__Scoreboard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003BA8 File Offset: 0x00001DA8
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002137 File Offset: 0x00000337
		public unsafe bool global
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_global);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_global)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003BD0 File Offset: 0x00001DD0
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003BF8 File Offset: 0x00001DF8
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000216D File Offset: 0x0000036D
		public unsafe int number
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_number);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_number)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00003C20 File Offset: 0x00001E20
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002188 File Offset: 0x00000388
		public unsafe AccountID relativeTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_relativeTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_relativeTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003C50 File Offset: 0x00001E50
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021A7 File Offset: 0x000003A7
		public unsafe Il2CppReferenceArray<AccountID> friends
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_friends);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_friends), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003C80 File Offset: 0x00001E80
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000021C6 File Offset: 0x000003C6
		public unsafe string URL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_URL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_URL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003CA8 File Offset: 0x00001EA8
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000021E5 File Offset: 0x000003E5
		public unsafe string Client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_Client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_Client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003CD0 File Offset: 0x00001ED0
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002204 File Offset: 0x00000404
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr__Scoreboard_k__BackingField;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_global;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeFieldInfoPtr_number;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_relativeTo;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_friends;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_URL;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_Client;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_Scoreboard_Public_get_Scoreboard_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_set_Scoreboard_Private_set_Void_Scoreboard_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_Int32_AccountID_Il2CppReferenceArray_1_AccountID_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__12_0_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__12_1_Private_Void_ErrorInfo_0;

		// Token: 0x02000016 RID: 22
		[ObfuscatedName("platformCore.scoreboard.FetchScoreboard+<execute>d__12")]
		public sealed class _execute_d__12 : Object
		{
			// Token: 0x06000103 RID: 259 RVA: 0x0000627C File Offset: 0x0000447C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__12()
			{
				Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FetchScoreboard>.NativeClassPtr, "<execute>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr);
				FetchScoreboard._execute_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, "<>1__state");
				FetchScoreboard._execute_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, "<>2__current");
				FetchScoreboard._execute_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, "<>4__this");
				FetchScoreboard._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, 100663317);
				FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, 100663318);
				FetchScoreboard._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, 100663319);
				FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, 100663320);
				FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, 100663321);
				FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr, 100663322);
			}

			// Token: 0x06000104 RID: 260 RVA: 0x0000635C File Offset: 0x0000455C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FetchScoreboard._execute_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard._execute_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000105 RID: 261 RVA: 0x000063A4 File Offset: 0x000045A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000106 RID: 262 RVA: 0x000063D8 File Offset: 0x000045D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249693, XrefRangeEnd = 1249766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard._execute_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000107 RID: 263 RVA: 0x00006414 File Offset: 0x00004614
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00006454 File Offset: 0x00004654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249766, XrefRangeEnd = 1249771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000109 RID: 265 RVA: 0x00006488 File Offset: 0x00004688
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FetchScoreboard._execute_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600010A RID: 266 RVA: 0x000029B8 File Offset: 0x00000BB8
			public _execute_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600010B RID: 267 RVA: 0x000064C8 File Offset: 0x000046C8
			// (set) Token: 0x0600010C RID: 268 RVA: 0x000029C1 File Offset: 0x00000BC1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard._execute_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard._execute_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600010D RID: 269 RVA: 0x000064F0 File Offset: 0x000046F0
			// (set) Token: 0x0600010E RID: 270 RVA: 0x000029DC File Offset: 0x00000BDC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard._execute_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard._execute_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600010F RID: 271 RVA: 0x00006520 File Offset: 0x00004720
			// (set) Token: 0x06000110 RID: 272 RVA: 0x000029FB File Offset: 0x00000BFB
			public unsafe FetchScoreboard __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard._execute_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FetchScoreboard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FetchScoreboard._execute_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000095 RID: 149
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000096 RID: 150
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000097 RID: 151
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000098 RID: 152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000099 RID: 153
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009A RID: 154
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400009B RID: 155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400009C RID: 156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400009D RID: 157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
