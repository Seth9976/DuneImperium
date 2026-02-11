using System;
using dwd.core;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Threading;

namespace boardgames.data.commands
{
	// Token: 0x0200014A RID: 330
	public class SaveLocalDataCommand : Command
	{
		// Token: 0x060010D6 RID: 4310 RVA: 0x00044CAC File Offset: 0x00042EAC
		// Note: this type is marked as 'beforefieldinit'.
		static SaveLocalDataCommand()
		{
			Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data.commands", "SaveLocalDataCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr);
			SaveLocalDataCommand.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "data");
			SaveLocalDataCommand.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "path");
			SaveLocalDataCommand.NativeFieldInfoPtr_threaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "threaded");
			SaveLocalDataCommand.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "status");
			SaveLocalDataCommand.NativeFieldInfoPtr_saveRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "saveRunning");
			SaveLocalDataCommand.NativeMethodInfoPtr__ctor_Public_Void_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, 100665756);
			SaveLocalDataCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, 100665757);
			SaveLocalDataCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, 100665758);
			SaveLocalDataCommand.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, 100665759);
			SaveLocalDataCommand.NativeMethodInfoPtr_threadedSerialize_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, 100665760);
			SaveLocalDataCommand.NativeMethodInfoPtr_serializeToDisk_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, 100665761);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00044DB8 File Offset: 0x00042FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999528, XrefRangeEnd = 999531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveLocalDataCommand(Object data, string path, bool threaded)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threaded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand.NativeMethodInfoPtr__ctor_Public_Void_Object_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00044E24 File Offset: 0x00043024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999531, XrefRangeEnd = 999536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveLocalDataCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00044E70 File Offset: 0x00043070
		[CallerCount(0)]
		public unsafe virtual ErrorInfo Status()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand.NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ErrorInfo(intPtr);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00044EA8 File Offset: 0x000430A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 999544, RefRangeEnd = 999545, XrefRangeStart = 999536, XrefRangeEnd = 999544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00044EDC File Offset: 0x000430DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999545, XrefRangeEnd = 999550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator threadedSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand.NativeMethodInfoPtr_threadedSerialize_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00044F1C File Offset: 0x0004311C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999550, XrefRangeEnd = 999557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void serializeToDisk(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand.NativeMethodInfoPtr_serializeToDisk_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00009D27 File Offset: 0x00007F27
		public SaveLocalDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x00044F54 File Offset: 0x00043154
		// (set) Token: 0x060010DF RID: 4319 RVA: 0x00009D30 File Offset: 0x00007F30
		public unsafe Object data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00044F84 File Offset: 0x00043184
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x00009D4F File Offset: 0x00007F4F
		public unsafe string path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00044FAC File Offset: 0x000431AC
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x00009D6E File Offset: 0x00007F6E
		public unsafe bool threaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_threaded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_threaded)) = value;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00044FD4 File Offset: 0x000431D4
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00009D89 File Offset: 0x00007F89
		public ErrorInfo status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_status);
				return new ErrorInfo(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand.NativeFieldInfoPtr_status), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ErrorInfo>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x00045004 File Offset: 0x00043204
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x00009DB7 File Offset: 0x00007FB7
		public unsafe static bool saveRunning
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SaveLocalDataCommand.NativeFieldInfoPtr_saveRunning, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveLocalDataCommand.NativeFieldInfoPtr_saveRunning, (void*)(&value));
			}
		}

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_threaded;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_saveRunning;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_String_Boolean_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr_Status_Public_Virtual_Final_New_ErrorInfo_0;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeMethodInfoPtr_threadedSerialize_Private_IEnumerator_0;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeMethodInfoPtr_serializeToDisk_Private_Static_Void_Object_0;

		// Token: 0x02000275 RID: 629
		[ObfuscatedName("boardgames.data.commands.SaveLocalDataCommand+<>O")]
		public static class __O : Object
		{
			// Token: 0x06001CEF RID: 7407 RVA: 0x0000F902 File Offset: 0x0000DB02
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<SaveLocalDataCommand.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveLocalDataCommand.__O>.NativeClassPtr);
				SaveLocalDataCommand.__O.NativeFieldInfoPtr__0___serializeToDisk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand.__O>.NativeClassPtr, "<0>__serializeToDisk");
			}

			// Token: 0x06001CF0 RID: 7408 RVA: 0x0000F936 File Offset: 0x0000DB36
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0006A5EC File Offset: 0x000687EC
			// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0000F93F File Offset: 0x0000DB3F
			public unsafe static ParameterizedThreadStart _0___serializeToDisk
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SaveLocalDataCommand.__O.NativeFieldInfoPtr__0___serializeToDisk, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterizedThreadStart>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SaveLocalDataCommand.__O.NativeFieldInfoPtr__0___serializeToDisk, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400119C RID: 4508
			private static readonly IntPtr NativeFieldInfoPtr__0___serializeToDisk;
		}

		// Token: 0x02000276 RID: 630
		[ObfuscatedName("boardgames.data.commands.SaveLocalDataCommand+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06001CF3 RID: 7411 RVA: 0x0006A614 File Offset: 0x00068814
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr);
				SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, "<>1__state");
				SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, "<>2__current");
				SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, "<>4__this");
				SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, 100665762);
				SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, 100665763);
				SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, 100665764);
				SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, 100665765);
				SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, 100665766);
				SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr, 100665767);
			}

			// Token: 0x06001CF4 RID: 7412 RVA: 0x0006A6F4 File Offset: 0x000688F4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveLocalDataCommand._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001CF5 RID: 7413 RVA: 0x0006A73C File Offset: 0x0006893C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CF6 RID: 7414 RVA: 0x0006A770 File Offset: 0x00068970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999483, XrefRangeEnd = 999496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0006A7AC File Offset: 0x000689AC
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CF8 RID: 7416 RVA: 0x0006A7EC File Offset: 0x000689EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999496, XrefRangeEnd = 999501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0006A820 File Offset: 0x00068A20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CFA RID: 7418 RVA: 0x0000F951 File Offset: 0x0000DB51
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0006A860 File Offset: 0x00068A60
			// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0000F95A File Offset: 0x0000DB5A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700089A RID: 2202
			// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0006A888 File Offset: 0x00068A88
			// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0000F975 File Offset: 0x0000DB75
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0006A8B8 File Offset: 0x00068AB8
			// (set) Token: 0x06001D00 RID: 7424 RVA: 0x0000F994 File Offset: 0x0000DB94
			public unsafe SaveLocalDataCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveLocalDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400119D RID: 4509
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400119E RID: 4510
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400119F RID: 4511
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011A0 RID: 4512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011A1 RID: 4513
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011A2 RID: 4514
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011A3 RID: 4515
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011A4 RID: 4516
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011A5 RID: 4517
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000277 RID: 631
		[ObfuscatedName("boardgames.data.commands.SaveLocalDataCommand+<threadedSerialize>d__9")]
		public sealed class _threadedSerialize_d__9 : Object
		{
			// Token: 0x06001D01 RID: 7425 RVA: 0x0006A8E8 File Offset: 0x00068AE8
			// Note: this type is marked as 'beforefieldinit'.
			static _threadedSerialize_d__9()
			{
				Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveLocalDataCommand>.NativeClassPtr, "<threadedSerialize>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr);
				SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, "<>1__state");
				SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, "<>2__current");
				SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, "<>4__this");
				SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr__thread_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, "<thread>5__2");
				SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, 100665768);
				SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, 100665769);
				SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, 100665770);
				SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, 100665771);
				SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, 100665772);
				SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr, 100665773);
			}

			// Token: 0x06001D02 RID: 7426 RVA: 0x0006A9DC File Offset: 0x00068BDC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _threadedSerialize_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveLocalDataCommand._threadedSerialize_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D03 RID: 7427 RVA: 0x0006AA24 File Offset: 0x00068C24
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D04 RID: 7428 RVA: 0x0006AA58 File Offset: 0x00068C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999501, XrefRangeEnd = 999523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008A2 RID: 2210
			// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0006AA94 File Offset: 0x00068C94
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D06 RID: 7430 RVA: 0x0006AAD4 File Offset: 0x00068CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999523, XrefRangeEnd = 999528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008A3 RID: 2211
			// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0006AB08 File Offset: 0x00068D08
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveLocalDataCommand._threadedSerialize_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D08 RID: 7432 RVA: 0x0000F9B3 File Offset: 0x0000DBB3
			public _threadedSerialize_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0006AB48 File Offset: 0x00068D48
			// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0000F9BC File Offset: 0x0000DBBC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0006AB70 File Offset: 0x00068D70
			// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0000F9D7 File Offset: 0x0000DBD7
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0006ABA0 File Offset: 0x00068DA0
			// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0000F9F6 File Offset: 0x0000DBF6
			public unsafe SaveLocalDataCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveLocalDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A1 RID: 2209
			// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0006ABD0 File Offset: 0x00068DD0
			// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0000FA15 File Offset: 0x0000DC15
			public unsafe Thread _thread_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr__thread_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveLocalDataCommand._threadedSerialize_d__9.NativeFieldInfoPtr__thread_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011A6 RID: 4518
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011A7 RID: 4519
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011A8 RID: 4520
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011A9 RID: 4521
			private static readonly IntPtr NativeFieldInfoPtr__thread_5__2;

			// Token: 0x040011AA RID: 4522
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011AB RID: 4523
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011AC RID: 4524
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011AD RID: 4525
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011AE RID: 4526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011AF RID: 4527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
