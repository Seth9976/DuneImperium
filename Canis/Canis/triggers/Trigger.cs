using System;
using Canis.actions;
using Canis.context;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.triggers
{
	// Token: 0x02000042 RID: 66
	public class Trigger : Object
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x0002A61C File Offset: 0x0002881C
		// Note: this type is marked as 'beforefieldinit'.
		static Trigger()
		{
			Il2CppClassPointerStore<Trigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.triggers", "Trigger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger>.NativeClassPtr);
			Trigger.NativeFieldInfoPtr_phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "phase");
			Trigger.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "source");
			Trigger.NativeFieldInfoPtr_onTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "onTrigger");
			Trigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100664176);
			Trigger.NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_OnTrigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100664177);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0002A6B0 File Offset: 0x000288B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Trigger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0002A6EC File Offset: 0x000288EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553161, XrefRangeEnd = 553164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Trigger(EntityID source, int p, Trigger.OnTrigger ot)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_OnTrigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00003CBF File Offset: 0x00001EBF
		public Trigger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0002A758 File Offset: 0x00028958
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003CC8 File Offset: 0x00001EC8
		public unsafe int phase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_phase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_phase)) = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0002A780 File Offset: 0x00028980
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003CE3 File Offset: 0x00001EE3
		public unsafe EntityID source
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_source);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0002A7B0 File Offset: 0x000289B0
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003D02 File Offset: 0x00001F02
		public unsafe Trigger.OnTrigger onTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_onTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger.OnTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_onTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeFieldInfoPtr_phase;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeFieldInfoPtr_source;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_onTrigger;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_OnTrigger_0;

		// Token: 0x0200029A RID: 666
		public sealed class OnTrigger : MulticastDelegate
		{
			// Token: 0x06001BED RID: 7149 RVA: 0x00085D28 File Offset: 0x00083F28
			// Note: this type is marked as 'beforefieldinit'.
			static OnTrigger()
			{
				Il2CppClassPointerStore<Trigger.OnTrigger>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "OnTrigger");
				Trigger.OnTrigger.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger.OnTrigger>.NativeClassPtr, 100664178);
				Trigger.OnTrigger.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_Int32_Match_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger.OnTrigger>.NativeClassPtr, 100664179);
				Trigger.OnTrigger.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Match_Context_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger.OnTrigger>.NativeClassPtr, 100664180);
				Trigger.OnTrigger.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger.OnTrigger>.NativeClassPtr, 100664181);
			}

			// Token: 0x06001BEE RID: 7150 RVA: 0x00085D9C File Offset: 0x00083F9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553154, XrefRangeEnd = 553157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnTrigger(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger.OnTrigger>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.OnTrigger.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BEF RID: 7151 RVA: 0x00085DF8 File Offset: 0x00083FF8
			[CallerCount(0)]
			public unsafe IEnumerable<Canis.actions.Action> Invoke(int phase, Match match, Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref phase;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.OnTrigger.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_Int32_Match_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001BF0 RID: 7152 RVA: 0x00085E68 File Offset: 0x00084068
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 553157, XrefRangeEnd = 553161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(int phase, Match match, Context context, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref phase;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.OnTrigger.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Match_Context_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001BF1 RID: 7153 RVA: 0x00085F00 File Offset: 0x00084100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Canis.actions.Action> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.OnTrigger.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
				}
			}

			// Token: 0x06001BF2 RID: 7154 RVA: 0x0000D504 File Offset: 0x0000B704
			public OnTrigger(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001BF3 RID: 7155 RVA: 0x0000D50D File Offset: 0x0000B70D
			public static implicit operator Trigger.OnTrigger(Func<int, Match, Context, IEnumerable<Canis.actions.Action>> A_0)
			{
				return DelegateSupport.ConvertDelegate<Trigger.OnTrigger>(A_0);
			}

			// Token: 0x06001BF4 RID: 7156 RVA: 0x0000D515 File Offset: 0x0000B715
			public static Trigger.OnTrigger operator +(Trigger.OnTrigger A_0, Trigger.OnTrigger A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Trigger.OnTrigger>();
			}

			// Token: 0x06001BF5 RID: 7157 RVA: 0x0000D523 File Offset: 0x0000B723
			public static Trigger.OnTrigger operator -(Trigger.OnTrigger A_0, Trigger.OnTrigger A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Trigger.OnTrigger>();
				}
				return delegate2;
			}

			// Token: 0x040011D3 RID: 4563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040011D4 RID: 4564
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerable_1_Action_Int32_Match_Context_0;

			// Token: 0x040011D5 RID: 4565
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_Match_Context_AsyncCallback_Object_0;

			// Token: 0x040011D6 RID: 4566
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerable_1_Action_IAsyncResult_0;
		}
	}
}
