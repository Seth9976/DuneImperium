using System;
using dwd.core;
using dwd.core.commands;
using dwd.platformCore.authentication;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace dwd.canis.dbg_client
{
	// Token: 0x020000A8 RID: 168
	public class DWDAccountAuth : Command
	{
		// Token: 0x0600080E RID: 2062 RVA: 0x0002A6B0 File Offset: 0x000288B0
		// Note: this type is marked as 'beforefieldinit'.
		static DWDAccountAuth()
		{
			Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "dwd.canis.dbg_client", "DWDAccountAuth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr);
			DWDAccountAuth.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, "status");
			DWDAccountAuth.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, "password");
			DWDAccountAuth.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, "username");
			DWDAccountAuth.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, 100664556);
			DWDAccountAuth.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, 100664557);
			DWDAccountAuth.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, 100664558);
			DWDAccountAuth.NativeMethodInfoPtr__execute_b__5_1_Private_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, 100664559);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0002A76C File Offset: 0x0002896C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991276, XrefRangeEnd = 991279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DWDAccountAuth(string username, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0002A7CC File Offset: 0x000289CC
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0002A804 File Offset: 0x00028A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991279, XrefRangeEnd = 991284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DWDAccountAuth.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0002A850 File Offset: 0x00028A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991284, XrefRangeEnd = 991293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__5_1(ErrorInfo e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(e));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth.NativeMethodInfoPtr__execute_b__5_1_Private_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00005A84 File Offset: 0x00003C84
		public DWDAccountAuth(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x0002A898 File Offset: 0x00028A98
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x00005A8D File Offset: 0x00003C8D
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x0002A8C8 File Offset: 0x00028AC8
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00005ABB File Offset: 0x00003CBB
		public unsafe string password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth.NativeFieldInfoPtr_password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth.NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0002A8F0 File Offset: 0x00028AF0
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x00005ADA File Offset: 0x00003CDA
		public unsafe string username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth.NativeFieldInfoPtr_username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeFieldInfoPtr_password;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeFieldInfoPtr_username;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_1_Private_Void_ErrorInfo_0;

		// Token: 0x02000216 RID: 534
		[ObfuscatedName("dwd.canis.dbg_client.DWDAccountAuth+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001875 RID: 6261 RVA: 0x0005CE8C File Offset: 0x0005B08C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DWDAccountAuth.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDAccountAuth.__c>.NativeClassPtr);
				DWDAccountAuth.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth.__c>.NativeClassPtr, "<>9");
				DWDAccountAuth.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth.__c>.NativeClassPtr, "<>9__5_0");
				DWDAccountAuth.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth.__c>.NativeClassPtr, 100664561);
				DWDAccountAuth.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_ErrorInfo_AuthenticatePlatformNoSession_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth.__c>.NativeClassPtr, 100664562);
			}

			// Token: 0x06001876 RID: 6262 RVA: 0x0005CF08 File Offset: 0x0005B108
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDAccountAuth.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001877 RID: 6263 RVA: 0x0005CF44 File Offset: 0x0005B144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991214, XrefRangeEnd = 991228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorInfo _execute_b__5_0(AuthenticatePlatformNoSession _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth.__c.NativeMethodInfoPtr__execute_b__5_0_Internal_ErrorInfo_AuthenticatePlatformNoSession_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ErrorInfo(intPtr);
				}
			}

			// Token: 0x06001878 RID: 6264 RVA: 0x0000D62D File Offset: 0x0000B82D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x06001879 RID: 6265 RVA: 0x0005CF8C File Offset: 0x0005B18C
			// (set) Token: 0x0600187A RID: 6266 RVA: 0x0000D636 File Offset: 0x0000B836
			public unsafe static DWDAccountAuth.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DWDAccountAuth.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDAccountAuth.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DWDAccountAuth.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x0600187B RID: 6267 RVA: 0x0005CFB4 File Offset: 0x0005B1B4
			// (set) Token: 0x0600187C RID: 6268 RVA: 0x0000D648 File Offset: 0x0000B848
			public unsafe static Func<AuthenticatePlatformNoSession, ErrorInfo> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DWDAccountAuth.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AuthenticatePlatformNoSession, ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DWDAccountAuth.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000ED0 RID: 3792
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000ED1 RID: 3793
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04000ED2 RID: 3794
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000ED3 RID: 3795
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__5_0_Internal_ErrorInfo_AuthenticatePlatformNoSession_0;
		}

		// Token: 0x02000217 RID: 535
		[ObfuscatedName("dwd.canis.dbg_client.DWDAccountAuth+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x0600187D RID: 6269 RVA: 0x0005CFDC File Offset: 0x0005B1DC
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DWDAccountAuth>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr);
				DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, "<>1__state");
				DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, "<>2__current");
				DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, "<>4__this");
				DWDAccountAuth._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, 100664563);
				DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, 100664564);
				DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, 100664565);
				DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, 100664566);
				DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, 100664567);
				DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr, 100664568);
			}

			// Token: 0x0600187E RID: 6270 RVA: 0x0005D0BC File Offset: 0x0005B2BC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DWDAccountAuth._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600187F RID: 6271 RVA: 0x0005D104 File Offset: 0x0005B304
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001880 RID: 6272 RVA: 0x0005D138 File Offset: 0x0005B338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991228, XrefRangeEnd = 991271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06001881 RID: 6273 RVA: 0x0005D174 File Offset: 0x0005B374
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001882 RID: 6274 RVA: 0x0005D1B4 File Offset: 0x0005B3B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991271, XrefRangeEnd = 991276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06001883 RID: 6275 RVA: 0x0005D1E8 File Offset: 0x0005B3E8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DWDAccountAuth._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001884 RID: 6276 RVA: 0x0000D65A File Offset: 0x0000B85A
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x06001885 RID: 6277 RVA: 0x0005D228 File Offset: 0x0005B428
			// (set) Token: 0x06001886 RID: 6278 RVA: 0x0000D663 File Offset: 0x0000B863
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06001887 RID: 6279 RVA: 0x0005D250 File Offset: 0x0005B450
			// (set) Token: 0x06001888 RID: 6280 RVA: 0x0000D67E File Offset: 0x0000B87E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06001889 RID: 6281 RVA: 0x0005D280 File Offset: 0x0005B480
			// (set) Token: 0x0600188A RID: 6282 RVA: 0x0000D69D File Offset: 0x0000B89D
			public unsafe DWDAccountAuth __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDAccountAuth>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DWDAccountAuth._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000ED4 RID: 3796
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000ED5 RID: 3797
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000ED6 RID: 3798
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000ED7 RID: 3799
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000ED8 RID: 3800
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000ED9 RID: 3801
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EDA RID: 3802
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EDB RID: 3803
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EDC RID: 3804
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
