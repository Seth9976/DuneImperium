using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003CC RID: 972
	public sealed class ConfiguredTaskAwaitable : ValueType
	{
		// Token: 0x0600398F RID: 14735 RVA: 0x00116550 File Offset: 0x00114750
		// Note: this type is marked as 'beforefieldinit'.
		static ConfiguredTaskAwaitable()
		{
			Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "ConfiguredTaskAwaitable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr);
			ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "m_configuredTaskAwaiter");
			ConfiguredTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100671879);
			ConfiguredTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, 100671880);
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x001165BC File Offset: 0x001147BC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1394109, RefRangeEnd = 1394114, XrefRangeStart = 1394107, XrefRangeEnd = 1394109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable(Task task, bool continueOnCapturedContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x0011661C File Offset: 0x0011481C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 599686, RefRangeEnd = 599697, XrefRangeStart = 599686, XrefRangeEnd = 599697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(intPtr);
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x0001556A File Offset: 0x0001376A
		public ConfiguredTaskAwaitable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00015573 File Offset: 0x00013773
		public ConfiguredTaskAwaitable()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr))
		{
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06003994 RID: 14740 RVA: 0x00116658 File Offset: 0x00114858
		// (set) Token: 0x06003995 RID: 14741 RVA: 0x00015585 File Offset: 0x00013785
		public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter);
				return new ConfiguredTaskAwaitable.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.NativeFieldInfoPtr_m_configuredTaskAwaiter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002EBC RID: 11964
		private static readonly IntPtr NativeFieldInfoPtr_m_configuredTaskAwaiter;

		// Token: 0x04002EBD RID: 11965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

		// Token: 0x04002EBE RID: 11966
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_ConfiguredTaskAwaiter_0;

		// Token: 0x0200068E RID: 1678
		public sealed class ConfiguredTaskAwaiter : ValueType, INotifyCompletion
		{
			// Token: 0x06005BD3 RID: 23507 RVA: 0x001A14E4 File Offset: 0x0019F6E4
			// Note: this type is marked as 'beforefieldinit'.
			static ConfiguredTaskAwaiter()
			{
				Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfiguredTaskAwaitable>.NativeClassPtr, "ConfiguredTaskAwaiter");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, "m_task");
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, "m_continueOnCapturedContext");
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100671881);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100671882);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100671883);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100671884);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr, 100671885);
			}

			// Token: 0x06005BD4 RID: 23508 RVA: 0x001A159C File Offset: 0x0019F79C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 906460, RefRangeEnd = 906466, XrefRangeStart = 906460, XrefRangeEnd = 906466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConfiguredTaskAwaiter(Task task, bool continueOnCapturedContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001781 RID: 6017
			// (get) Token: 0x06005BD5 RID: 23509 RVA: 0x001A15FC File Offset: 0x0019F7FC
			public unsafe bool IsCompleted
			{
				[CallerCount(604)]
				[CachedScanResults(RefRangeStart = 1393084, RefRangeEnd = 1393688, XrefRangeStart = 1393084, XrefRangeEnd = 1393688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005BD6 RID: 23510 RVA: 0x001A1640 File Offset: 0x0019F840
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1394100, RefRangeEnd = 1394103, XrefRangeStart = 1394097, XrefRangeEnd = 1394100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BD7 RID: 23511 RVA: 0x001A1688 File Offset: 0x0019F888
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1394106, RefRangeEnd = 1394107, XrefRangeStart = 1394103, XrefRangeEnd = 1394106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UnsafeOnCompleted(Action continuation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005BD8 RID: 23512 RVA: 0x001A16D0 File Offset: 0x0019F8D0
			[CallerCount(311)]
			[CachedScanResults(RefRangeStart = 1393696, RefRangeEnd = 1394007, XrefRangeStart = 1393696, XrefRangeEnd = 1394007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void GetResult()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005BD9 RID: 23513 RVA: 0x000214B7 File Offset: 0x0001F6B7
			public ConfiguredTaskAwaiter(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005BDA RID: 23514 RVA: 0x000214C0 File Offset: 0x0001F6C0
			public ConfiguredTaskAwaiter()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter>.NativeClassPtr))
			{
			}

			// Token: 0x1700177F RID: 6015
			// (get) Token: 0x06005BDB RID: 23515 RVA: 0x001A1708 File Offset: 0x0019F908
			// (set) Token: 0x06005BDC RID: 23516 RVA: 0x000214D2 File Offset: 0x0001F6D2
			public unsafe Task m_task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001780 RID: 6016
			// (get) Token: 0x06005BDD RID: 23517 RVA: 0x001A1738 File Offset: 0x0019F938
			// (set) Token: 0x06005BDE RID: 23518 RVA: 0x000214F1 File Offset: 0x0001F6F1
			public unsafe bool m_continueOnCapturedContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter.NativeFieldInfoPtr_m_continueOnCapturedContext)) = value;
				}
			}

			// Token: 0x06005BDF RID: 23519 RVA: 0x0002150C File Offset: 0x0001F70C
			public void OnCompleted(Action continuation)
			{
				this.OnCompleted(continuation);
			}

			// Token: 0x04004AB9 RID: 19129
			private static readonly IntPtr NativeFieldInfoPtr_m_task;

			// Token: 0x04004ABA RID: 19130
			private static readonly IntPtr NativeFieldInfoPtr_m_continueOnCapturedContext;

			// Token: 0x04004ABB RID: 19131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Boolean_0;

			// Token: 0x04004ABC RID: 19132
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

			// Token: 0x04004ABD RID: 19133
			private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004ABE RID: 19134
			private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

			// Token: 0x04004ABF RID: 19135
			private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;
		}
	}
}
