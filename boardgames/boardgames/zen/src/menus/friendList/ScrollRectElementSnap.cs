using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace zen.src.menus.friendList
{
	// Token: 0x0200005E RID: 94
	public class ScrollRectElementSnap : MonoBehaviour
	{
		// Token: 0x060004EA RID: 1258 RVA: 0x0001F6C4 File Offset: 0x0001D8C4
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollRectElementSnap()
		{
			Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus.friendList", "ScrollRectElementSnap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr);
			ScrollRectElementSnap.NativeFieldInfoPtr_stepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, "stepSize");
			ScrollRectElementSnap.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, "content");
			ScrollRectElementSnap.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, "lerpTime");
			ScrollRectElementSnap.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, "points");
			ScrollRectElementSnap.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, "rect");
			ScrollRectElementSnap.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, 100663969);
			ScrollRectElementSnap.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, 100663970);
			ScrollRectElementSnap.NativeMethodInfoPtr_OnPointerUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, 100663971);
			ScrollRectElementSnap.NativeMethodInfoPtr_LerpToGameObject_Public_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, 100663972);
			ScrollRectElementSnap.NativeMethodInfoPtr_LerpTo_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, 100663973);
			ScrollRectElementSnap.NativeMethodInfoPtr_FindNearestPoint_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, 100663974);
			ScrollRectElementSnap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, 100663975);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986530, XrefRangeEnd = 986534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001F818 File Offset: 0x0001DA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986534, XrefRangeEnd = 986543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001F84C File Offset: 0x0001DA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986543, XrefRangeEnd = 986552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap.NativeMethodInfoPtr_OnPointerUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001F880 File Offset: 0x0001DA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986552, XrefRangeEnd = 986559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpToGameObject(GameObject gameObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap.NativeMethodInfoPtr_LerpToGameObject_Public_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001F8D0 File Offset: 0x0001DAD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 986564, RefRangeEnd = 986566, XrefRangeStart = 986559, XrefRangeEnd = 986564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LerpTo(float target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap.NativeMethodInfoPtr_LerpTo_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0001F91C File Offset: 0x0001DB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 986580, RefRangeEnd = 986581, XrefRangeStart = 986566, XrefRangeEnd = 986580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float FindNearestPoint(float current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap.NativeMethodInfoPtr_FindNearestPoint_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001F968 File Offset: 0x0001DB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986581, XrefRangeEnd = 986596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScrollRectElementSnap()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000448D File Offset: 0x0000268D
		public ScrollRectElementSnap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00004496 File Offset: 0x00002696
		public unsafe float stepSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_stepSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_stepSize)) = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0001F9CC File Offset: 0x0001DBCC
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x000044B1 File Offset: 0x000026B1
		public unsafe RectTransform content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001F9FC File Offset: 0x0001DBFC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x000044D0 File Offset: 0x000026D0
		public unsafe float lerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_lerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_lerpTime)) = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001FA24 File Offset: 0x0001DC24
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x000044EB File Offset: 0x000026EB
		public unsafe List<float> points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001FA54 File Offset: 0x0001DC54
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x0000450A File Offset: 0x0000270A
		public unsafe ScrollRect rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_stepSize;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Public_Void_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_LerpToGameObject_Public_IEnumerator_GameObject_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_LerpTo_Private_IEnumerator_Single_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_FindNearestPoint_Private_Single_Single_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001CC RID: 460
		[ObfuscatedName("zen.src.menus.friendList.ScrollRectElementSnap+<LerpTo>d__9")]
		public sealed class _LerpTo_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x060015D4 RID: 5588 RVA: 0x0005478C File Offset: 0x0005298C
			// Note: this type is marked as 'beforefieldinit'.
			static _LerpTo_d__9()
			{
				Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRectElementSnap>.NativeClassPtr, "<LerpTo>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr);
				ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, "<>1__state");
				ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, "<>2__current");
				ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, "<>4__this");
				ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, "target");
				ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__rectTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, "<rectTransform>5__2");
				ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__start_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, "<start>5__3");
				ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__time_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, "<time>5__4");
				ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, 100663976);
				ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, 100663977);
				ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, 100663978);
				ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, 100663979);
				ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, 100663980);
				ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr, 100663981);
			}

			// Token: 0x060015D5 RID: 5589 RVA: 0x000548BC File Offset: 0x00052ABC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LerpTo_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectElementSnap._LerpTo_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060015D6 RID: 5590 RVA: 0x00054904 File Offset: 0x00052B04
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060015D7 RID: 5591 RVA: 0x00054938 File Offset: 0x00052B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986509, XrefRangeEnd = 986525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00054974 File Offset: 0x00052B74
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015D9 RID: 5593 RVA: 0x000549B4 File Offset: 0x00052BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986525, XrefRangeEnd = 986530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x060015DA RID: 5594 RVA: 0x000549E8 File Offset: 0x00052BE8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectElementSnap._LerpTo_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060015DB RID: 5595 RVA: 0x0000C34D File Offset: 0x0000A54D
			public _LerpTo_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x060015DC RID: 5596 RVA: 0x00054A28 File Offset: 0x00052C28
			// (set) Token: 0x060015DD RID: 5597 RVA: 0x0000C356 File Offset: 0x0000A556
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x060015DE RID: 5598 RVA: 0x00054A50 File Offset: 0x00052C50
			// (set) Token: 0x060015DF RID: 5599 RVA: 0x0000C371 File Offset: 0x0000A571
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00054A80 File Offset: 0x00052C80
			// (set) Token: 0x060015E1 RID: 5601 RVA: 0x0000C390 File Offset: 0x0000A590
			public unsafe ScrollRectElementSnap __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRectElementSnap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00054AB0 File Offset: 0x00052CB0
			// (set) Token: 0x060015E3 RID: 5603 RVA: 0x0000C3AF File Offset: 0x0000A5AF
			public unsafe float target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr_target);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr_target)) = value;
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00054AD8 File Offset: 0x00052CD8
			// (set) Token: 0x060015E5 RID: 5605 RVA: 0x0000C3CA File Offset: 0x0000A5CA
			public unsafe RectTransform _rectTransform_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__rectTransform_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__rectTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00054B08 File Offset: 0x00052D08
			// (set) Token: 0x060015E7 RID: 5607 RVA: 0x0000C3E9 File Offset: 0x0000A5E9
			public unsafe float _start_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__start_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__start_5__3)) = value;
				}
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x060015E8 RID: 5608 RVA: 0x00054B30 File Offset: 0x00052D30
			// (set) Token: 0x060015E9 RID: 5609 RVA: 0x0000C404 File Offset: 0x0000A604
			public unsafe float _time_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__time_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectElementSnap._LerpTo_d__9.NativeFieldInfoPtr__time_5__4)) = value;
				}
			}

			// Token: 0x04000D3F RID: 3391
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000D40 RID: 3392
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000D41 RID: 3393
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000D42 RID: 3394
			private static readonly IntPtr NativeFieldInfoPtr_target;

			// Token: 0x04000D43 RID: 3395
			private static readonly IntPtr NativeFieldInfoPtr__rectTransform_5__2;

			// Token: 0x04000D44 RID: 3396
			private static readonly IntPtr NativeFieldInfoPtr__start_5__3;

			// Token: 0x04000D45 RID: 3397
			private static readonly IntPtr NativeFieldInfoPtr__time_5__4;

			// Token: 0x04000D46 RID: 3398
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000D47 RID: 3399
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D48 RID: 3400
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000D49 RID: 3401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000D4A RID: 3402
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000D4B RID: 3403
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
